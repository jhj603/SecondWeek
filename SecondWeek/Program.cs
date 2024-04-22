namespace SecondWeek
{
    internal class Program
    {
        static bool IsPrime(int num)
        {
            if (0 == (num % 2))
            {
                if (2 == num)
                    return true;
                else
                    return false;
            }

            if (0 == (num % 3))
            {
                if (3 == num)
                    return true;
                else
                    return false;
            }

            if (0 == (num % 5))
            {
                if (5 == num)
                    return true;
                else
                    return false;
            }

            if (0 == (num % 7))
            {
                if (7 == num)
                    return true;
                else
                    return false;
            }

            return true;
        }

        static void PrintBoard(int[] _boardAry)
        {
            int count = 0, current = 0;

            Console.WriteLine("     l     l     ");

            current = count;
            for (int i = count; 2 >= (i - current); ++i)
            {
                Console.Write("  ");

                if (-1 == _boardAry[i])
                    Console.Write('O');
                else if (0 == _boardAry[i])
                    Console.Write('X');
                else
                    Console.Write(_boardAry[i]);

                Console.Write("  ");

                if (2 != (i - current))
                    Console.Write('l');
                else if (2 == (i - current))
                    count = i + 1;
            }
            Console.WriteLine();

            Console.WriteLine("-----l-----l-----");
            Console.WriteLine("     l     l     ");

            current = count;
            for (int i = count; 2 >= (i - current); ++i)
            {
                Console.Write("  ");

                if (-1 == _boardAry[i])
                    Console.Write('O');
                else if (0 == _boardAry[i])
                    Console.Write('X');
                else
                    Console.Write(_boardAry[i]);

                Console.Write("  ");

                if (2 != (i - current))
                    Console.Write('l');
                else if (2 == (i - current))
                    count = i + 1;
            }
            Console.WriteLine();

            Console.WriteLine("-----l-----l-----");
            Console.WriteLine("     l     l     ");

            current = count;
            for (int i = count; 2 >= (i - current); ++i)
            {
                Console.Write("  ");

                if (-1 == _boardAry[i])
                    Console.Write('O');
                else if (0 == _boardAry[i])
                    Console.Write('X');
                else
                    Console.Write(_boardAry[i]);

                Console.Write("  ");

                if (2 != (i - current))
                    Console.Write('l');
            }
            Console.WriteLine();

            Console.WriteLine("     l     l     ");
        }

        static void Main(string[] args)
        {
            // 2 - 1
            //for (int i = 1; i < 10; ++i)
            //{
            //    for (int j = 1; j < 10; ++j)
            //        Console.WriteLine($"{i} X {j} = {i * j}");
            //}

            // 2 - 2
            //for (int i = 0; i < 5; ++i)
            //{
            //    for (int j = 0; j <= i; ++j)
            //        Console.Write('*');

            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 5; i > 0; --i)
            //{
            //    for (int j = 0; j < i; ++j)
            //        Console.Write('*');

            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < 5; ++i)
            //{
            //    for (int j = 1; j < (5 - i); ++j)
            //        Console.Write(' ');

            //    for (int j = 0; j <= i; ++j)
            //        Console.Write('*');

            //    for (int j = 0; j < i; ++j)
            //        Console.Write('*');

            //    Console.WriteLine();
            //}

            // 2 - 3
            //int input, min = int.MaxValue, max = int.MinValue;

            //for (int i = 0; i < 5; ++i)
            //{
            //    Console.Write("숫자를 입력하세요. : ");

            //    input = int.Parse(Console.ReadLine());

            //    if (min > input)
            //        min = input;
            //    else if (max < input)
            //        max = input;
            //}

            //Console.WriteLine($"최대값 : {max}");
            //Console.WriteLine($"최소값 : {min}");

            // 2 - 4
            //Console.Write("숫자를 입력하세요. : ");
            //int num = int.Parse(Console.ReadLine());

            //if (IsPrime(num))
            //    Console.WriteLine($"{num}은 소수입니다.");
            //else
            //    Console.WriteLine($"{num}은 소수가 아닙니다.");

            // 2 - 5
            //Random rand = new Random();
            //int count = 0, playerPick = 0, computerPick = rand.Next(1, 101);

            //Console.WriteLine("숫자 맞추기 게임을 시작합니다. 1에서 100까지의 숫자 중 하나를 맞춰보세요.");

            //do
            //{
            //    Console.Write("숫자를 입력하세요. : ");
            //    playerPick = int.Parse(Console.ReadLine());

            //    ++count;

            //    if (playerPick > computerPick)
            //        Console.WriteLine("너무 큽니다!");
            //    else if (playerPick < computerPick)
            //        Console.WriteLine("너무 작습니다!");

            //} while (playerPick != computerPick);

            //Console.WriteLine($"축하합니다! {count}번 만에 숫자를 맞췄습니다.");

            // 2 - 6
            int turn = 0, input = 0;
            int[] boardAry = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; ; ++i)
            {
                Console.Clear();

                Console.WriteLine("플레이어 1 : X 와 플레이어 2 : O");

                turn = i % 2;

                if (0 == turn)
                    Console.WriteLine("플레이어 1의 차례");
                else
                    Console.WriteLine("플레이어 2의 차례");

                Console.WriteLine();

                PrintBoard(boardAry);

                if ((boardAry[0] == boardAry[1]) && (boardAry[0] == boardAry[2]))
                {
                    if (0 == boardAry[0])
                    {
                        Console.WriteLine("플레이어 1 승!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("플레이어 2 승!");
                        break;
                    }
                }
                if ((boardAry[3] == boardAry[4] && boardAry[3] == boardAry[5]))
                {
                    if (0 == boardAry[3])
                    {
                        Console.WriteLine("플레이어 1 승!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("플레이어 2 승!");
                        break;
                    }
                }
                if ((boardAry[6] == boardAry[7] && boardAry[6] == boardAry[8]))
                {
                    if (0 == boardAry[6])
                    {
                        Console.WriteLine("플레이어 1 승!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("플레이어 2 승!");
                        break;
                    }
                }

                if ((boardAry[0] == boardAry[3]) && (boardAry[0] == boardAry[6]))
                {
                    if (0 == boardAry[0])
                    {
                        Console.WriteLine("플레이어 1 승!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("플레이어 2 승!");
                        break;
                    }
                }
                if ((boardAry[1] == boardAry[4] && boardAry[1] == boardAry[7]))
                {
                    if (0 == boardAry[1])
                    {
                        Console.WriteLine("플레이어 1 승!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("플레이어 2 승!");
                        break;
                    }
                }
                if ((boardAry[2] == boardAry[5] && boardAry[2] == boardAry[8]))
                {
                    if (0 == boardAry[2])
                    {
                        Console.WriteLine("플레이어 1 승!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("플레이어 2 승!");
                        break;
                    }
                }

                if (((boardAry[0] == boardAry[4]) && (boardAry[0] == boardAry[8])) ||
                    ((boardAry[2] == boardAry[4]) && (boardAry[2] == boardAry[6])))
                {
                    if (0 == boardAry[4])
                    {
                        Console.WriteLine("플레이어 1 승!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("플레이어 2 승!");
                        break;
                    }
                }

                Console.Write("돌을 놓을 위치를 입력하세요. : ");
                input = int.Parse(Console.ReadLine());

                if (0 == turn)
                    boardAry[input - 1] = 0;
                else
                    boardAry[input - 1] = -1;
            }
        }
    }
}
