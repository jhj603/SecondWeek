namespace SecondWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 조건문 : 주어진 조건식의 결과에 따라 프로그램의 제어 흐름을 변경하는 제어문
            // if 문 : 조건식의 결과에 따라 실행 여부를 결정하는 조건문
            int playerScore = 80;

            if (playerScore >= 70)      // 80 >= 70 이므로 true라서 코드 실행
            {
                Console.WriteLine("플레이어의 점수는 70점 이상");
            }

            // else 문 : if문의 조건식이 거짓일 경우 실행할 코드를 지정하는 조건문
            int itemCount = 5;
            string itemName = "HP 포션";

            if (0 < itemCount)
            {
                Console.WriteLine($"보유한 {itemName}의 수량 : {itemCount}");
            }
            else    // itemCount가 0 이하라면 else문 실행
            {
                Console.WriteLine($"보유한 {itemName}이 없습니다.");
            }

            // else if 문 : if문의 조건식이 거짓일 때, 새로운 조건식을 사용해 실행 여부를 결정하는 조건문
            //              else문은 생략 가능
            playerScore = 100;
            string playerRank = "";

            if (playerScore >= 90)          // playerScore가 90 이상이면
            {
                playerRank = "Diamond";
            }
            else if (playerScore >= 80)     // playerScore가 90 미만이고 80 이상이면
            {
                playerRank = "Platinum";
            }
            else if (playerScore >= 70)     // playerScore가 80 미만이고 70 이상이면
            {
                playerRank = "Gold";
            }
            else if (playerScore >= 60)     // playerScore가 70 미만이고 60 이상이면
            {
                playerRank = "Silver";
            }
            else                            // playerScore가 60 미만이면
            {
                playerRank = "Bronze";
            }

            Console.WriteLine("플레이어의 등급은 " + playerRank + "입니다.");

            // 중첩 조건문 : 하나의 조건문 안에 또 다른 조건문이 포함된 조건문
            int itemLevel = 3; // 아이템 레벨
            string itemType = "Weapon"; // 아이템 종류

            if (itemType == "Weapon")       // itemType이 Weapon일 때
            {
                if (itemLevel == 1)         // itemType이 Weapon이고 itemLevel이 1일 때
                {
                    // 레벨 1 무기 효과
                    Console.WriteLine("공격력이 10 증가했습니다.");
                }
                else if (itemLevel == 2)
                {
                    // 레벨 2 무기 효과
                    Console.WriteLine("공격력이 20 증가했습니다.");
                }
                else
                {
                    // 그 외 무기 레벨
                    Console.WriteLine("잘못된 아이템 레벨입니다.");
                }
            }
            else if (itemType == "Armor")   // itemType이 Armor일 때
            {
                if (itemLevel == 1)         // itemType이 Armor이고 itemLevel이 1일 때
                {
                    // 레벨 1 방어구 효과
                    Console.WriteLine("방어력이 10 증가했습니다.");
                }
                else if (itemLevel == 2)
                {
                    // 레벨 2 방어구 효과
                    Console.WriteLine("방어력이 20 증가했습니다.");
                }
                else
                {
                    // 그 외 방어구 레벨
                    Console.WriteLine("잘못된 아이템 레벨입니다.");
                }
            }
            else
            {
                // 그 외 아이템 종류
                Console.WriteLine("잘못된 아이템 종류입니다.");
            }

            // switch 문 : 변수나 식의 결과에 따라 다른 코드 블록을 실행하는 제어문.
            //             case문을 사용해 변수나 식의 결과에 따라 실행할 코드 지정
            //             해당 case문을 실행하면서 break를 만날 때까지 코드 진행
            string job = Console.ReadLine();

            switch (job)
            {
                case "1":       // 1일 때 진입
                    Console.WriteLine("전사를 선택하셨습니다.");
                    break;
                case "2":       // 2일 때 진입
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    break;
                case "3":       // 3일 때 진입
                    Console.WriteLine("궁수를 선택하셨습니다.");
                    break;
                default:        // 1, 2, 3 값이 아닐 때 진입
                    Console.WriteLine("올바른 값을 입력해주세요.");
                    break;
            }

            // 3항 연산자 : if문의 간단한 형태로, 조건식의 결과에 따라 두 값을 선택하는 연산자
            // (조건식) ? 참일 경우 값 : 거짓일 경우 값;
            int currentExp = 1200;
            int requiredExp = 2000;

            // 3항 연산자
            string result = (currentExp >= requiredExp) ? "레벨업 가능" : "레벨업 불가능";
            Console.WriteLine(result);

            // if문
            if (currentExp >= requiredExp)
            {
                Console.WriteLine("레벨업 가능");
            }
            else
            {
                Console.WriteLine("레벨업 불가능");
            }

            // 홀수 / 짝수 구분 : %(나머지) 연산을 이용해서 짝수 구분
            Console.Write("번호를 입력하세요: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)    // 2로 나눴을 때 나머지가 0이면 2의 배수
            {
                Console.WriteLine("짝수입니다.");
            }
            else
            {
                Console.WriteLine("홀수입니다.");
            }

            // 등급 출력
            playerScore = 100;
            playerRank = "";

            switch (playerScore / 10)       // 10으로 나눠 10의 자리 수의 값에 따라 case 실행
            {
                case 10:                    // break가 없어 case 9의 코드도 실행된다.
                case 9:                     // 90점대와 100점은 Diamond
                    playerRank = "Diamond";
                    break;
                case 8:                     // 80점대는 Platinum
                    playerRank = "Platinum";
                    break;
                case 7:                     // 70점대는 Gold
                    playerRank = "Gold";
                    break;
                case 6:                     // 60점대는 Silver
                    playerRank = "Silver";
                    break;
                default:                    // 그 이하거나 11 이상인 경우
                    playerRank = "Bronze";
                    break;
            }

            Console.WriteLine("플레이어의 등급은 " + playerRank + "입니다.");

            // 로그인 프로그램
            string id = "myid";
            string password = "mypassword";

            Console.Write("아이디를 입력하세요: ");
            string inputId = Console.ReadLine();
            Console.Write("비밀번호를 입력하세요: ");
            string inputPassword = Console.ReadLine();

            if (inputId == id && inputPassword == password)     // inputId가 myid와 같고 inputPassword가 mypassword
                                                                // 와 같으면 코드 실행
            {
                Console.WriteLine("로그인 성공!");
            }
            else                                                // 둘 중 하나라도 다르면 코드 실행
            {
                Console.WriteLine("로그인 실패...");
            }

            // 알파벳 판별 프로그램
            Console.Write("문자를 입력하세요: ");
            char input = Console.ReadLine()[0];     // 문자열을 입력받아 첫 문자를 저장

            if (input >= 'a' && input <= 'z' || input >= 'A' && input <= 'Z')
            {
                Console.WriteLine("알파벳입니다.");
            }
            else
            {
                Console.WriteLine("알파벳이 아닙니다.");
            }
        }
    }
}
