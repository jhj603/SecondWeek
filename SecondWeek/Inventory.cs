using SecondWeek;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal class Inventory
    {
        Player player = null;
        List<Item> items = null;

        int selectInput = 0;

        Item sellItem = null;

        public Inventory(Player _player)
        {
            player = _player;
            items = new List<Item>();
        }

        public void Show_Inventory()
        {
            while (true)
            {
                CommonDraw();

                foreach (Item item in items)
                {
                    Console.Write(" - ");

                    if (item.IsEquip)
                        Console.Write("[E]");

                    Console.Write($"{item.Name}\t|\t");

                    if (ItemType.WEAPON == item.ItemType)
                        Console.WriteLine($"공격력 +{item.Attack}\t|\t{item.Description}");
                    else if (ItemType.ARMOR == item.ItemType)
                        Console.WriteLine($"방어력 +{item.Defense}\t|\t{item.Description}");
                }

                Console.WriteLine();
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Manage_Item();
                        break;
                    case "0":
                        return;
                    default:
                        Program.Input_Error();
                        break;
                }
            }
        }

        public void Add_Item(Item _item)
        {
            items.Add(_item);
        }

        public Item Sell_Item()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{player.Gold} G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");

                for (int i = 0; i < items.Count; ++i)
                {
                    Console.Write($" - {i + 1} ");

                    if (items[i].IsEquip)
                        Console.Write("[E] ");

                    Console.Write($"{items[i].Name}   |  ");

                    if (ItemType.WEAPON == items[i].ItemType)
                        Console.Write($"공격력 +{items[i].Attack}\t");
                    else if (ItemType.ARMOR == items[i].ItemType)
                        Console.Write($"방어력 +{items[i].Defense}\t");

                    Console.WriteLine($"|  {items[i].Description}\t|  {(int)(items[i].Gold * 0.85f)} G");
                }

                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                if (int.TryParse(Console.ReadLine(), out selectInput))
                {
                    if ((1 <= selectInput) && (items.Count >= selectInput))
                    {
                        sellItem = items[selectInput - 1];
                        items.Remove(sellItem);

                        if (sellItem.IsEquip)
                            sellItem.IsEquip = !sellItem.IsEquip;

                        return sellItem;
                    }
                    else if (0 == selectInput)
                        return null;
                    else
                        Program.Input_Error();
                }
                else
                    Program.Input_Error();
            }
        }

        public void Save_Data()
        {
            string fileName = "PlayerInvenData.json";
            string filePath = Path.Combine("../../../../", fileName);

            var options = new JsonSerializerOptions { WriteIndented = true };

            string playerInvenData = JsonSerializer.Serialize(items, options);

            playerInvenData = Regex.Unescape(playerInvenData);

            File.WriteAllText(filePath, playerInvenData);
        }

        public void Load_Data()
        {
            string fileName = "PlayerInvenData.json";
            string filePath = Path.Combine("../../../../", fileName);

            if (File.Exists(filePath))
            {
                string InvenJson = File.ReadAllText(filePath);

                InvenJson = Regex.Unescape(InvenJson);

                items = JsonSerializer.Deserialize<List<Item>>(InvenJson);

                foreach (Item item in items)
                {
                    if (item.IsEquip)
                    {
                        if (ItemType.WEAPON == item.ItemType)
                            player.SetWeapon(item);
                        else if (ItemType.ARMOR == item.ItemType)
                            player.SetArmor(item);
                    }
                }
            }
        }

        public bool Check_Item(Item _item)
        {
            foreach (Item item in items)
            {
                if (_item.Name == item.Name)
                    return true;
            }

            return false;
        }

        void CommonDraw()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[ 아이템 목록 ]");
        }

        void Manage_Item()
        {
            while (true)
            {
                CommonDraw();

                for (int i = 0; i < items.Count; ++i)
                {
                    Console.Write($" - {(i + 1)} ");

                    if (items[i].IsEquip)
                        Console.Write("[E]");

                    Console.Write($"{items[i].Name} | ");

                    if (ItemType.WEAPON == items[i].ItemType)
                        Console.WriteLine($"공격력 +{items[i].Attack} | {items[i].Description}");
                    else if (ItemType.ARMOR == items[i].ItemType)
                        Console.WriteLine($"방어력 +{items[i].Defense} | {items[i].Description}");
                }

                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                if (int.TryParse(Console.ReadLine(), out selectInput))
                {
                    if ((1 <= selectInput) && (items.Count >= selectInput))
                        player.Equip_Item(items[selectInput - 1]);
                    else if (0 == selectInput)
                        return;
                    else
                        Program.Input_Error();
                }
                else
                    Program.Input_Error();
            }
        }
    }
}
