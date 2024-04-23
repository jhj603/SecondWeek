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
    }
}
