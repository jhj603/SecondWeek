using System;       //C#에서 기본으로 제공하는 System 네임스페이스를 사용하기 위한 코드
                    //Console 클래스를 사용하기 위해 필요

namespace SecondWeek    //코드를 구성하는 데 사용되며 클래스 및 기타 네임스페이스의 컨테이너
{
    internal class Program     //C# 클래스를 정의하는 키워드. 클래스의 이름은 Program
    {
        static void Main(string[] args)     //C#의 진입점(entry point) 함수. 프로그램이 시작할 때
        {                                   //자동으로 호출되는 메서드로 프로그램 실행에 필수적
            
            Console.WriteLine("Hello, World!");     //콘솔에 출력할 내용을 지정하는 코드
                                                    //WriteLine 함수는 새 줄을 시작하고 출력할 문자열을 
                                                    //매개변수로 받음.

            //{} : 코드 블록의 시작과 끝을 나타내는 중괄호
            //; : 모든 C#의 코드는 세미콜론(;)으로 끝남.

            Console.WriteLine("My Name Is JHJ");

            Console.WriteLine(10);          //output : 10
            Console.WriteLine(3.141592);    //output : 3.141592
            Console.WriteLine(3 + 3);       //output : 6

            // Console.Write() : Console.WriteLine 함수와 유사하지만 줄 바꿈 문자열을 추가하지 않음
            //                   출력한 후 다음 출력이 이어서 출력됨.

            Console.Write("Hello! ");               //중간 output : Hello! 
            Console.Write("We are Learning ");      //중간 output : Hello! We are Learning 
            Console.WriteLine("at TeamSparta");     //최종 output : Hello! We are Learning at TeamSparta
                                                    //              이후 줄바꿈

            // 이스케이프 시퀀스(Escape Sequence) : 문자열 내에 특수한 문자를 포함시키기 위해 사용되는 문자 조합
            // \' : 작은 따옴표(') 삽입
            // \" : 큰 따옴표(") 삽입
            // \\ : 역슬래시(\) 삽입
            // \n : 새 줄(줄바꿈) 삽입
            // \r : 현재 줄 맨 앞으로 이동
            // \t : 탭 삽입
            // \b : 백스페이스 삽입
        }
    }
}

// 주석(Comments) : 코드의 설명이나 개발자간의 의사소통을 위해 사용

// 주석의 종류
// // : 한줄 주석. 해당 줄 끝까지 주석 처리
// /* */ : 여러 줄 주석. 시작과 끝을 명시해 주석 처리

// 주석의 장점 : 코드 작성 과정에서 중요한 역할을 수행, 설계한 내용을 주석으로 작성하면 나중에 코드
//               수정 시 도움이 됨.

// 주석 사용 시 주의할 점
// 1. 주석은 코드를 대체하지 않음 : 코드를 설명하거나 보충하는 역할을 하기 때문에 코드의 복잡한 부분이나
//                                  로직을 대체하지 않아야 함.
//2. 주석의 내용은 정확하고 명확해야 함 : 코드의 작동 방식이나 의도를 명확하게 설명해야 함. 주석이
//                                        혼란스럽거나 모호하다면 코드 이해를 방해함. 주석에 틀린 정보가
//                                        포함되지 않도록 주의할 것
//3. 주석은 업데이트 되어야 함 : 코드가 변경되면 주석도 변경되어야 함. 오래된 버전의 코드를 설명하는 것일
//                               경우 코드와 맞지 않는 정보를 제공할 수도 있음. 코드의 변경에 맞춰 업데이트
//                               되어야 함.
//4. 주석은 필요한 경우에만 사용 : 코드가 명확하고 의도가 분명하다면 필요하지 않을 수 있음. 불필요한 주석은
//                                 코드를 복잡하게 만들 수 있기 때문에 코드를 이해하는 데 도움이 될 경우에만
//                                 사용