namespace SecondWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 반복문 : 일련의 명령문을 반복해서 실행하는 제어문
            // for 문 : 초기식, 조건식, 증감식을 사용하는 반복문
            //          초기식은 반복 시작 시 단 한 번 실행하고, 조건식은 반복할 때마다 평가되며, true인
            //          경우 반복을 수행. 증감식은 반복 코드 수행 후 실행되는 식.
            // for (초기식; 조건식; 증감식)
            // {
            //     반복할 코드
            // }
            for (int i = 0; i < 10; i++)    // i가 0부터 9까지 1씩 증가하면서 10번 반복
            {
                Console.WriteLine(i);       // 0부터 9까지 한 줄씩 출력
            }

            // 초기식의 변수는 미리 만들어 놓은 변수로 사용 가능
            int l = 0;
            for (l = 0; l < 10; l++)
            {
                Console.WriteLine(l);
            }

            // 증감식으로 반복의 횟수를 조절할 수 있다.
            for (int i = 0; i < 10; i += 2)     // i를 2씩 증가시켜 0 ~ 10 사이의 짝수를 출력
            {
                Console.WriteLine(i);
            }

            // while 문 : 조건식이 참(true)인 동안 코드 블록을 반복적으로 실행하는 반복문
            // while (조건식)
            // {
            //    // 조건식이 참인 경우 실행되는 코드
            // }
            int count = 0;
            while (count < 10)      // count가 10 미만이면 반복 수행
            {
                Console.WriteLine("적을 처치했습니다! 남은 적 수: " + (10 - count - 1));
                count++;        // count를 1씩 증가시켜 10번 반복
            }

            Console.WriteLine("축하합니다! 게임에서 승리하셨습니다!");

            // for 문과 while 문의 차이
            // for 문 : 반복 횟수를 직관적으로 알 수 있고 반복 조건을 한 눈에 확인할 수 있어 가독성이 좋음
            // while 문 : 반복 조건에 따라 조건문의 실행 횟수가 유동적이기 때문에 코드가 간결할 수 있음
            // 코드의 흐름에 따라 상황에 맞게 선택해서 사용하면 됨.

            // do-while 문 : 조건식을 검사하기 전에 먼저 코드 블록을 한 번 실행하는 while 문
            // do
            // {
            //    // 조건식이 참인 경우 실행되는 코드
            // }
            // while (조건식);
            int sum = 0;
            int num;

            do      // 먼저 코드 블록 실행
            {
                Console.Write("숫자를 입력하세요 (0 입력 시 종료): ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);     // 입력받은 수가 0이 아니면 다시 반복

            Console.WriteLine("합계: " + sum);

            // foreach 문 : 배열이나 컬렉션에 대한 반복문을 작성할 때 사용
            // foreach (자료형 변수 in 배열 또는 컬렉션)
            // {
            //    // 배열 또는 컬렉션의 모든 요소에 대해 반복적으로 실행되는 코드
            // }
            string[] inventory = { "검", "방패", "활", "화살", "물약" };

            foreach (string item in inventory)      // inventory에 저장된 데이터들을 item에 차례대로 저장
            {
                Console.WriteLine(item);        // "검", "방패", "활", "화살", "물약" 순으로 한 줄씩 출력
            }

            // 중첩 반복문
            for (int i = 0; i < 5; i++)         // i의 값에 따라 총 5번 반복
            {
                for (int j = 0; j < 3; j++)     // j의 값에 따라 총 3번 반복
                {
                    Console.WriteLine("i: {0}, j: {1}", i, j);      
                }
                // 3번씩 반복하는 이중 반복문을 5번 반복하므로 총 15번의 반복이 수행됨.
            }

            // break : 반복문을 중지시킴
            // continue : 현재의 반복을 중지하고 바로 다음 반복으로 진행시킴
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue; // 3의 배수인 경우 다음 숫자로 넘어감
                }

                Console.WriteLine(i);
                if (i == 7)
                {
                    break; // 7이 출력된 이후에는 반복문을 빠져나감
                }
            }

            // 가위바위보
            string[] choices = { "가위", "바위", "보" };
            string playerChoice = "";
            string computerChoice = choices[new Random().Next(0, 3)];

            while (playerChoice != computerChoice)      // 플레이어가 선택한 문자열과 컴퓨터가 선택한 문자열이
                                                        // 서로 다를 때 반복 수행
            {
                Console.Write("가위, 바위, 보 중 하나를 선택하세요: ");
                playerChoice = Console.ReadLine();

                Console.WriteLine("컴퓨터: " + computerChoice);

                if (playerChoice == computerChoice)     // 플레이어의 선택 문자열과 컴퓨터 선택 문자열이 서로
                                                        // 같은 경우
                {
                    Console.WriteLine("비겼습니다!");
                }
                else if ((playerChoice == "가위" && computerChoice == "보") ||     // 플레이어가 이기는 상황의
                         (playerChoice == "바위" && computerChoice == "가위") ||   // 경우
                         (playerChoice == "보" && computerChoice == "바위"))
                {
                    Console.WriteLine("플레이어 승리!");
                }
                else            // 플레이어가 지는 경우
                {
                    Console.WriteLine("컴퓨터 승리!");
                }
            }

            // 숫자 맞추기
            int targetNumber = new Random().Next(1, 101); ;
            int guess = 0;
            count = 0;

            Console.WriteLine("1부터 100 사이의 숫자를 맞춰보세요.");

            while (guess != targetNumber)       // 플레이어가 입력한 수가 맞춰야 하는 수와 다른 경우 반복
            {
                Console.Write("추측한 숫자를 입력하세요: ");
                guess = int.Parse(Console.ReadLine());
                count++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("좀 더 큰 숫자를 입력하세요.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("좀 더 작은 숫자를 입력하세요.");
                }
                else
                {
                    Console.WriteLine("축하합니다! 숫자를 맞추셨습니다.");
                    Console.WriteLine("시도한 횟수: " + count);
                }
            }
        }
    }
}
