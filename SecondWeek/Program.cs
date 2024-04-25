using System.ComponentModel;

namespace SecondWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();

            if (mainGame.Initialize())  // 게임에 필요한 것들 초기화
                mainGame.Update();      // 게임을 진행
        }

        public static void Input_Error()
        {
            Console.WriteLine();
            Console.WriteLine("잘못된 입력입니다.");

            Thread.Sleep(1000);

            Console.Clear();
        }
    }
}
