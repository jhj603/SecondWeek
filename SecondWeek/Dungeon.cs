using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal class Dungeon : Map
    {
        int stageInput = 0;

        int randPercent = 0;
        Random rand = null;

        int recomendDef = 0;

        int preHP = 0;
        int preGold = 0;

        public Dungeon()
        {
            rand = new Random();
        }

        public override void Update(Player _player)
        {
            player = _player;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("던전 입장");
                Console.WriteLine("이곳에서 던전의 난이도를 고를 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 쉬운 던전\t| 방어력 5 이상 권장");
                Console.WriteLine("2. 일반 던전\t| 방어력 11 이상 권장");
                Console.WriteLine("3. 어려운 던전\t| 방어력 17 이상 권장");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                if (int.TryParse(Console.ReadLine(), out stageInput))
                {
                    if ((0 < stageInput) && (4 > stageInput))
                    {
                        if (0 < player.HP)
                            Proceed_Dungeon(stageInput);
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("HP가 없습니다..!");

                            Thread.Sleep(1000);
                        }
                    }
                    else if (0 == stageInput)
                        return;
                    else
                        Program.Input_Error();
                }
                else
                    Program.Input_Error();
            }
        }

        void Proceed_Dungeon(int _difficulty)
        {
            recomendDef = (6 * (_difficulty - 1)) + 5;

            if (recomendDef > player.Get_RealDefense())
            {
                randPercent = rand.Next(0, 10);

                if (4 > randPercent)
                {
                    preHP = player.HP;
                    player.HP /= 2;

                    Failed_Dungeon();
                }
                else
                    Clear_Dungeon();
            }
            else
                Clear_Dungeon();
        }

        void Failed_Dungeon()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("던전 공략 실패..!!");
                Console.Write("에헤이...");
                
                switch (stageInput)
                {
                    case 1:
                        Console.Write("쉬운 던전");
                        break;
                    case 2:
                        Console.Write("일반 던전");
                        break;
                    case 3:
                        Console.Write("어려운 던전");
                        break;
                }

                Console.WriteLine(" 공략을 실패 했습니다.");
                Console.WriteLine();
                Console.WriteLine("[탐험 결과]");
                Console.WriteLine($"체력 {preHP}\t=>{player.HP}");
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

        void Clear_Dungeon()
        {
            preHP = player.HP;
            preGold = player.Gold;

            player.HP -= (rand.Next(20, 36) + (player.Get_RealDefense() - recomendDef));

            if (0 > player.HP)
                player.HP = 0;

            switch (stageInput)
            {
                case 1:
                    player.Gold += (1000 + (int)(1000 * (rand.Next((int)player.Get_RealAttack(), ((int)player.Get_RealAttack() * 2) + 1) / 100f)));
                    break;
                case 2:
                    player.Gold += (1700 + (int)(1700 * (rand.Next((int)player.Get_RealAttack(), ((int)player.Get_RealAttack() * 2) + 1) / 100f)));
                    break;
                case 3:
                    player.Gold += (1000 + (int)(2500 * (rand.Next((int)player.Get_RealAttack(), ((int)player.Get_RealAttack() * 2) + 1) / 100f)));
                    break;
            }

            while (true)
            {
                Console.Clear();

                Console.WriteLine("던전 클리어!!");
                Console.WriteLine("축하합니다!!");

                switch (stageInput)
                {
                    case 1:
                        Console.Write("쉬운 던전");
                        break;
                    case 2:
                        Console.Write("일반 던전");
                        break;
                    case 3:
                        Console.Write("어려운 던전");
                        break;
                }

                Console.WriteLine("을 클리어 했습니다.");
                Console.WriteLine();
                Console.WriteLine("[탐험 결과]");

                if (player.Clear_Dungeon())
                {
                    Console.WriteLine();
                    Console.WriteLine("레벨 업!!!");
                    Console.WriteLine();
                }

                Console.WriteLine($"체력 {preHP}\t=>{player.HP}");
                Console.WriteLine($"Gold {preGold} G\t=>{player.Gold} G");
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
    }
}
