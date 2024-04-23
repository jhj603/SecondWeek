namespace SecondWeek
{
    public enum Direction
    {
        RIGHT,
        LEFT,
        UP,
        DOWN
    }

    class Point
    {
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    class Snake
    {
        public Snake(int x, int y, Direction dir)
        {
            curPoint = new Point(x, y);
            curDir = dir;
            PointsList = new List<Point>();
        }

        public void GoFront()                       // 전진 함수
        {
            switch (curDir)
            {
                case Direction.RIGHT:
                    curPoint.X += 1;
                    break;
                case Direction.LEFT:
                    curPoint.X -= 1;
                    break;
                case Direction.UP:
                    curPoint.Y -= 1;
                    break;
                case Direction.DOWN:
                    curPoint.Y += 1;
                    break;
            }
        }

        public void ChangeDir(Direction _dir)       // 방향 전환 함수
        {
            curDir = _dir;
        }

        public bool GetFood(FoodCreator foodCreator)                       // 음식 먹기 함수
        {
            foreach (Point food in foodCreator.FoodList)
            {
                if ((curPoint.X == food.X) && (curPoint.Y == food.Y))
                {
                    foodCreator.FoodList.Remove(food);
                    PointsList.Add(new Point(curPoint.X, curPoint.Y));

                    return true;
                }
            }

            return false;
        }

        public bool IsCrash()                       // 몸 충돌 확인 함수
        {
            foreach (Point point in PointsList)
            {
                return (curPoint.X == point.X && curPoint.Y == point.Y);
            }

            return false;
        }

        public bool IsOut(int _endX, int _endY)     // 맵 충돌 확인 함수
        {
            if ((0 >= curPoint.X) || (_endX <= curPoint.X))
                return true;

            if ((0 >= curPoint.Y) || (_endY < curPoint.Y))
                return true;

            return false;
        }

        public void Draw()                          // 화면 출력 함수
        {
            foreach (Point point in PointsList)
            {
                Console.SetCursorPosition(point.X, point.Y);
                Console.Write('*');
            }

            Console.SetCursorPosition(curPoint.X, curPoint.Y);
            Console.Write('@');
        }

        Point curPoint;
        Direction curDir;

        public List<Point> PointsList { get; }
    }

    class FoodCreator
    {
        public FoodCreator(int _x, int _y)
        {
            maxX = _x;
            maxY = _y;

            FoodList = new List<Point>();

            rand = new Random();
        }

        public void SpawnFood(Snake playerSnake)
        {
            int tempX, tempY;
            bool isIn = false;

            // 문제야
            //while (true)
            //{
            //    tempX = rand.Next(1, maxX - 1);
            //    tempY = rand.Next(1, maxY - 1);

            //    foreach (Point tail in playerSnake.PointsList)
            //    {
            //        if ((tempX == tail.X) && (tempY == tail.Y))
            //        {
            //            isIn = true;
            //            break;
            //        }
            //    }

            //    if (!isIn)
            //    {
            //        FoodList.Add(new Point(tempX, tempY));
            //        break;
            //    }
            //}
        }

        public void Draw()
        {
            foreach (Point food in FoodList)
            {
                Console.SetCursorPosition(food.X, food.Y);
                Console.Write('F');
            }
        }

        int maxX, maxY;
        Random rand;
        public List<Point> FoodList { get; }
    }

    internal class Program
    {
        static void BoardMake(int _x, int _y)
        {
            for (int i = 0; i <= (_y + 1) ; ++i)
            {
                if ((0 == i) || ((_y + 1) == i))
                {
                    for (int j = 0; j <= (_x + 1); ++j)
                        Console.Write('-');
                }
                else
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write('l');

                    Console.SetCursorPosition(_x, i);
                    Console.Write('l');
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("게임 보드의 크기를 입력해주세요. (예 : 5x5 -> 5 5) : ");

            string[] inputs = Console.ReadLine().Split();

            int score = 0, boardX = int.Parse(inputs[0]), boardY = int.Parse(inputs[1]);
            Snake playerSnake = new Snake(1, 1, Direction.RIGHT);
            FoodCreator foodCreator = new FoodCreator(boardX, boardY);

            while (true)
            {
                Console.Clear();

                BoardMake(boardX, boardY);

                Console.WriteLine($"현재 점수 : {score}");

                foodCreator.SpawnFood(playerSnake);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (ConsoleKey.RightArrow == keyInfo.Key)
                        playerSnake.ChangeDir(Direction.RIGHT);

                    else if (ConsoleKey.LeftArrow == keyInfo.Key)
                        playerSnake.ChangeDir(Direction.LEFT);

                    else if (ConsoleKey.UpArrow == keyInfo.Key)
                        playerSnake.ChangeDir(Direction.UP);

                    else if (ConsoleKey.DownArrow == keyInfo.Key)
                        playerSnake.ChangeDir(Direction.DOWN);
                }

                playerSnake.GoFront();

                if (playerSnake.GetFood(foodCreator))
                    score += 10;

                if (playerSnake.IsOut(boardX, boardY))// || playerSnake.IsCrash())
                    break;

                playerSnake.Draw();
                foodCreator.Draw();

                Thread.Sleep(1000);
            }

            Console.Clear();

            Console.WriteLine("Game Over!");
            Console.WriteLine($"점수 : {score}");
        }
    }
}
