using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SecondWeek
{
    internal class Player
    {
        public int Level { get; set; } = 1;
        public string Name { get; set; } = "JHJ";
        public string PlayerClass { get; set; } = "전사";
        public float Attack { get; set; } = 10f;
        public int Defense { get; set; } = 5;
        public int HP { get; set; } = 100;
        public int Gold { get; set; } = 1500;

        public int MaxHP { get; set; } = 100;
        public int Exp { get; set; } = 0;

        Inventory inventory = null;

        Item itemWeapon = null;
        Item itemArmor = null;

        int selectInput = 0;

        Item sellItem = null;

        public Player()
        {
            inventory = new Inventory(this);
        }

        public void Status_Render()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine();
                Console.WriteLine("Lv. " + Level.ToString("D2"));
                Console.WriteLine($"{Name} ( {PlayerClass} )");

                if (null != itemWeapon)
                    Console.WriteLine($"공격력 : {Get_RealAttack()} (+{itemWeapon.Attack})");
                else
                    Console.WriteLine($"공격력 : {Get_RealAttack()}");

                if (null != itemArmor)
                    Console.WriteLine($"방어력 : {Get_RealDefense()} (+{itemArmor.Defense})");
                else
                    Console.WriteLine($"방어력 : {Get_RealDefense()}");

                Console.WriteLine($"체 력 : {HP}");
                Console.WriteLine($"Gold : {Gold} G");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                if ("0" == Console.ReadLine())
                    return;
                else
                    Program.Input_Error();
            }
        }

        public void Inven_Render()
        {
            inventory.Show_Inventory();
        }

        public void Equip_Item(Item _item)
        {
            _item.IsEquip = !_item.IsEquip;

            if (ItemType.WEAPON == _item.ItemType)
            {
                if (_item.IsEquip)
                {
                    if (null != itemWeapon)
                        itemWeapon.IsEquip = !itemWeapon.IsEquip;

                    itemWeapon = _item;
                }
                else
                    itemWeapon = null;
            }
            else if (ItemType.ARMOR == _item.ItemType)
            {
                if (_item.IsEquip)
                {
                    if (null != itemArmor)
                        itemArmor.IsEquip = !itemArmor.IsEquip;

                    itemArmor = _item;
                }
                else
                    itemArmor = null;
            }
        }

        public void Rest(int _fee)
        {
            HP = MaxHP;
            Gold -= _fee;

            Console.WriteLine("휴식을 완료했습니다.");
        }

        public bool Buy_Item(Item _item)
        {
            if (_item.Gold <= Gold)
            {
                Gold -= _item.Gold;
                inventory.Add_Item(_item);

                Console.WriteLine("구매를 완료했습니다.");

                return true;
            }

            Console.WriteLine("Gold 가 부족합니다.");

            return false;
        }

        public Item Sell_Item()
        {
            sellItem = inventory.Sell_Item();

            if (null != sellItem)
            {
                if (itemWeapon == sellItem)
                    itemWeapon = null;

                else if (itemArmor == sellItem)
                    itemArmor = null;

                Gold += (int)(sellItem.Gold * 0.85f);
            }
            
            return sellItem;
        }

        public float Get_RealAttack()
        {
            if (null == itemWeapon)
                return Attack;
            
            return Attack + itemWeapon.Attack;
        }

        public int Get_RealDefense()
        {
            if (null == itemArmor)
                return Defense;
            
            return Defense + itemArmor.Defense;
        }

        public bool Clear_Dungeon()
        {
            ++Exp;

            if (Level <= Exp)
            {
                ++Level;
                Exp = 0;

                Attack += 0.5f;
                Defense += 1;

                MaxHP += 50;

                HP = MaxHP;

                return true;
            }

            return false;
        }

        public void Inven_Save()
        {
            inventory.Save_Data();
        }

        public void Load_Data()
        {
            inventory.Load_Data();
        }

        public bool Check_Item(Item _item)
        {
            return inventory.Check_Item(_item);
        }

        public void SetWeapon(Item _item)
        {
            if (null != itemWeapon)
                itemWeapon.IsEquip = !itemWeapon.IsEquip;

            itemWeapon = _item;
        }

        public void SetArmor(Item _item)
        {
            if (null != itemArmor)
                itemArmor.IsEquip = !itemArmor.IsEquip;

            itemArmor = _item;
        }
    }
}
