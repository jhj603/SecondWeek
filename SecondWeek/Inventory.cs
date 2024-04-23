using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    public enum ItemType
    {
        WEAPON,
        ARMOR
    }

    public struct Item
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public bool IsEquip { get; set; }
        public ItemType ItemType { get; set; }
        public int Gold { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(int _attack, int _defense, ItemType _itemType, int _gold, string _name, string _desc, bool _isEquip = false)
        {
            Attack = _attack;
            Defense = _defense;
            ItemType = _itemType;
            Gold = _gold;
            IsEquip = _isEquip;
            Name = _name;
            Description = _desc;
        }
    }

    internal class Inventory
    {
        Player player = null;
        List<Item> items = null;

        public Inventory(Player _player)
        {
            player = _player;
            items = new List<Item>();
        }

        public void Draw()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("[ 아이템 목록 ]");

                foreach (Item item in items)
                {
                    Console.Write("- ");

                    if (item.IsEquip)
                        Console.Write("[E]");

                    Console.Write($"{item.Name} | ");

                    if (ItemType.WEAPON == item.ItemType)
                        Console.WriteLine($"공격력 +{item.Attack} | {item.Description}");
                    else if (ItemType.ARMOR == item.ItemType)
                        Console.WriteLine($"방어력 +{item.Defense} | {item.Description}");
                }

                Console.WriteLine();
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("2. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.WriteLine(">>");


            }
        }
    }
}
