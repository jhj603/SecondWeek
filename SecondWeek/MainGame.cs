using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal class MainGame
    {
        Player player = null;

        public bool Initialize()
        {
            if (null == player)
                player = new Player();

            return true;
        }

        public void Update()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("4. 던전 입장");
                Console.WriteLine("5. 휴식하기");
                Console.WriteLine();
                Console.WriteLine("8. 게임 저장");
                Console.WriteLine("9. 게임 불러오기");
                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");

                switch (Console.ReadLine())
                {
                    case "1":
                        player.Status_Render();
                        break;
                    case "2":
                        player.Inven_Render();
                        break;
                    case "3":

                    case "4":

                        break;
                    case "5":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    default:
                        Program.Input_Error();
                        break;
                }
            }
        }
    }
}
