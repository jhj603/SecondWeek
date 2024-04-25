using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal class Shop : Map
    {
        List<Item> sellItems = null;
        bool[] isSellItem;

        int selectInput = 0;

        Item sellItem = null;

        public Shop()
        {
            sellItems = new List<Item>();

            sellItems.Add(new Item(0, 5, ItemType.ARMOR, 1000, "수련자 갑옷", "수련에 도움을 주는 갑옷입니다."));
            sellItems.Add(new Item(0, 9, ItemType.ARMOR, 2000, "무쇠 갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다"));
            sellItems.Add(new Item(0, 15, ItemType.ARMOR, 3500, "스파르타의 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다."));
            sellItems.Add(new Item(2, 0, ItemType.WEAPON, 600, "낡은 검", "쉽게 볼 수 있는 낡은 검입니다."));
            sellItems.Add(new Item(5, 0, ItemType.WEAPON, 1500, "청동 도끼", "어디선가 사용됐던거 같은 도끼입니다."));
            sellItems.Add(new Item(7, 0, ItemType.WEAPON, 2500, "스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다."));
            sellItems.Add(new Item(999, 0, ItemType.WEAPON, 5000, "창성님의 날카로운 눈빛", "모든 것을 베어버릴 수 있습니다."));
            sellItems.Add(new Item(0, 999, ItemType.ARMOR, 5000, "태일님의 용기의 문장", "한 단계 진화할 수 있는 신기한 문장입니다."));

            isSellItem = new bool[sellItems.Count];
        }

        public override void Update(Player _player)
        {
            player = _player;

            for (int i = 0; i < sellItems.Count; ++i)
            {
                if (player.Check_Item(sellItems[i]))
                    isSellItem[i] = true;
                else
                    isSellItem[i] = false;
            }

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

                for (int i = 0; i < sellItems.Count; ++i)
                {
                    Console.Write(" - ");

                    Console.Write($"{sellItems[i].Name}   |  ");

                    if (ItemType.WEAPON == sellItems[i].ItemType)
                        Console.Write($"공격력 +{sellItems[i].Attack}\t");
                    else if (ItemType.ARMOR == sellItems[i].ItemType)
                        Console.Write($"방어력 +{sellItems[i].Defense}\t");

                    Console.Write($"|  {sellItems[i].Description}\t|");

                    if (!isSellItem[i])
                        Console.WriteLine($"  {sellItems[i].Gold} G");
                    else
                        Console.WriteLine("  구매 완료");
                }

                Console.WriteLine();
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("2. 아이템 판매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Buy_Item();
                        break;
                    case "2":
                        sellItem = player.Sell_Item();

                        if (null != sellItem)
                        {
                            for (int i = 0; i < sellItems.Count; ++i)
                            {
                                if (sellItem.Name == sellItems[i].Name)
                                    isSellItem[i] = false;
                            }
                        }
                        break;
                    case "0":
                        return;
                    default:
                        Program.Input_Error();
                        break;
                }
            }
        }

        void Buy_Item()
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

                for (int i = 0; i < sellItems.Count; ++i)
                {
                    Console.Write($" - {i + 1} ");

                    Console.Write($"{sellItems[i].Name}   |  ");

                    if (ItemType.WEAPON == sellItems[i].ItemType)
                        Console.Write($"공격력 +{sellItems[i].Attack}\t");
                    else if (ItemType.ARMOR == sellItems[i].ItemType)
                        Console.Write($"방어력 +{sellItems[i].Defense}\t");

                    Console.Write($"|  {sellItems[i].Description}\t|");

                    if (!isSellItem[i])
                        Console.WriteLine($"  {sellItems[i].Gold} G");
                    else
                        Console.WriteLine("  구매 완료");
                }

                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                if (int.TryParse(Console.ReadLine(), out selectInput))
                {
                    if ((1 <= selectInput) && (sellItems.Count >= selectInput))
                    {
                        Console.WriteLine();

                        if (isSellItem[selectInput - 1])
                            Console.WriteLine("이미 구매한 아이템입니다.");
                        else
                        {
                            if (player.Buy_Item(sellItems[selectInput - 1]))
                                isSellItem[selectInput - 1] = !isSellItem[selectInput - 1];
                        }

                        Thread.Sleep(1000);
                    }
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
