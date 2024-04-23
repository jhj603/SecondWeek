using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal class Player
    {
        public int Level { get; } = 1;
        public string Name { get; } = "JHJ";
        public string PlayerClass { get; } = "전사";
        public int Attack { get; } = 10;
        public int Defense { get; } = 5;
        public int HP { get; } = 100;
        public int Gold { get; } = 1500;

        Inventory inventory = null;

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
                Console.WriteLine($"공격력 : {Attack}");
                Console.WriteLine($"방어력 : {Defense}");
                Console.WriteLine($"체 력 : {HP}");
                Console.WriteLine($"Gold : {Gold} G");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");

                if ("0" == Console.ReadLine())
                    return;
                else
                    Program.Input_Error();
            }
        }

        public void Inven_Render()
        {
            inventory.Draw();
        }
    }
}
