﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal class Town : Map
    {
        public override void Update()
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            if (int.TryParse(Console.ReadLine(), out selectInput))
            {
                if (input == 1)
                    Player.DrawStatus();
            }
        }
        public override void Draw()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1.상태 보기");
            Console.WriteLine("2.인벤토리");
            Console.WriteLine("3.상점");
            Console.WriteLine("4.던전");
            Console.WriteLine();
        }
    }
}
