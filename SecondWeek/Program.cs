﻿using System.Numerics;

namespace SecondWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수 : 데이터(숫자, 문자 등)를 저장하고 사용하기 위해 할당받은 공간
            //        데이터를 저장하거나 수정 가능.

            // 변수 선언
            // 자료형 변수이름;
            int num;

            // 한 번에 여러 변수를 선언할 수 있음.
            int num1, num2, num3, num4;

            // 변수 초기화
            // 변수이름 = 값;
            num = 10;

            // 변수 선언과 동시에 초기화 가능
            int num5 = 5;   // 변수 선언과 초기화를 한 번에 수행

            // 한 번에 여러 개의 변수를 초기화 할 수 있는데 동일한 값으로 초기화됨.
            num1 = num2 = num3 = 10;    //num1, num2, num3 모두 10으로 초기화

            // 형변환 : 자료형이 다른 변수 간에 값을 할당하거나 연산을 수행하기 위한 변환
            // 명시적 형변환 : 변수명 앞에 (자료형)을 붙여 수행
            long lnum1 = (long)num1;    //int를 long으로 명시적 형변환

            // 암시적 형변환 : 직접 형변환 코드를 작성하지 않아도 되므로 코드를 간결하게 작성 가능
            //                 암시적 형변환이 발생하는 경우 데이터 타입을 고려해서 코드를 작성해야 함.
            // 1. 작은 데이터 타입 -> 더 큰 데이터 타입
            byte bnum1 = 10;
            int num6 = bnum1;   // byte형에서 int형으로 암시적 형변환
            // 2. 리터럴 값 대입
            float result1 = 1;  // 1은 int형 리터럴 값이지만 float형으로 암시적 형변환
            // 3. 정수형과 부동소수점형 간의 연산 수행
            int num7 = 10;
            float fnum1 = 3.14f;
            float result2 = num7 + fnum1;   //int형과 float형의 덧셈에서 float형으로 암시적 형변환

            // Console.ReadLine() : 콘솔 입력을 위한 함수. 사용자가 입력한 값을 문자열로 반환
            //                      숫자나 논리 값을 입력 받을 때는 적절한 형변환을 해줘야 함.
            string input = Console.ReadLine();

            //Split() : 여러 개의 값을 한 줄로 입력받았을 때, 문자열을 분리해서 처리할 수 있도록 하는 함수
            //          매개변수로 구분 문자를 넘기면 해당 문자를 기준으로 문자열을 분리해서 문자열 배열에
            //          저장. 반환값이 문자열 배열
            Console.Write("Enter two numbers: ");
            input = Console.ReadLine();    // "10 20"과 같은 문자열을 입력받음

            string[] numbers = input.Split(' ');  // 문자열을 공백으로 구분하여 배열로 만듦
                                                  // 매개변수로 아무것도 사용하지 않으면 기본으로 공백 문자로
                                                  // 분리

            num1 = int.Parse(numbers[0]);     // 첫 번째 문자열을 정수로 변환하여 저장
            num2 = int.Parse(numbers[1]);     // 두 번째 문자열을 정수로 변환하여 저장

            int sum = num1 + num2;            // 두 수를 더하여 결과를 계산

            Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);
            // The sum of 10 and 20 is 30. 출력

            // var : C# 3.0 이상부터 사용 가능한 자료형. 컴파일러에 의해 변수의 자료형이 자동으로 결정
            //       초기화하는 값의 자료형에 따라 변수의 자료형이 결정됨.
            var numvar = 10;         // int 자료형으로 결정됨
            var name = "kero";   // string 자료형으로 결정됨
            var pi = 3.141592;    // double 자료형으로 결정됨
        }
    }
}

// C# 주요 자료형
// int : 정수 자료형, 4 Byte, -2,147,483,648 ~ 2,147,483,647 의 정수를 표현
// long : 정수 자료형, 8 Bytte, -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807 의 정수를 표현

// float : 실수 자료형, 4 Byte, ±1.5 × 10^-45 ~ ±3.4 × 10^38의 실수를 표현
// double : 실수 자료형, 8 Byte, ±5.0 × 10^-324 ~ ±1.7 × 10^308의 실수를 표현

// char : 문자 자료형, 2 Byte, 유니코드 문자 표현
// string : 문자열 자료형, 유니코드 문자열 표현

// bool : 논리 자료형, 1 Byte, true 또는 false 표현

// 변수의 자료형이 세분화 되어있는 이유
// 1. 메모리의 효율적인 사용 : 세분화된 자료형을 사용하는 것으로 해당 자료형이 필요한 크기만큼의 메모리를
//                            할당해 메모리의 효율적인 사용을 가능하게 함.
// 2. 정확한 데이터 표현 : 데이터의 특성에 따라 정확한 표현이 가능.
//                         예를 들어, 부동소수점 자료형인 float과 double은 표현할 수 있는 소수점 이하
//                         자릿수가 달라 각각의 자료형은 다른 범위의 값까지 표현이 가능.
// 3. 타입 안정성 : 코드의 타입 안정성을 유지하기 위함.
//                  예를 들어, 정수형 자료형으로 byte를 사용하면, 해당 자료형이 가질 수 있는 값의 범위를
//                  벗어날 경우 오류가 발생하므로, 코드의 안정성을 보장할 수 있음.

// 리터럴 : 프로그램에서 사용되는 상수 값. 소스 코드에 직접 기록되어 있는 값.
//          C#에서 리터럴은 컴파일러에 의해 상수 값으로 처리, 변수나 상수에 할당되거나 연산에 사용

// 리터럴의 종류
// 정수형 리터럴 : 10(int), 0x10(16진수 int), 0b10(2진수 int), 10L(long), 10UL(unsigned long)
// 부동소수점형(실수형) 리터럴 : 3.14(double), 3.14f(float), 3.14m(decimal)
// 문자형 리터럴 : 'A'(char), '\n'(개행 문자), '\u0022'(유니코드 문자)
// 문자열 리터럴 : "Hello, World!"(string), "문자열 내 "따옴표" 사용하기", @"문자열 내 개행 문자 사용하기"

// 키워드 : 변수, 메소드, 클래스 등의 이름으로 사용할 수 없는 이미 예약된 단어들

// 식별자 : 키워드를 제외한 변수, 메서드, 클래스, 인터페이스 등에 사용되는 이름

// 식별자 사용 규칙
// 1. 첫 문자로 알파벳, 언더스코어(_)가 올 수 있음
// 2. 두번째 문자부터 알파벳, 언더스코어, 숫자가 올 수 있음
// 3. 대소문자 구분
// 4. 키워드와 같은 이름으로 사용 불가

// 코드 컨벤션 : 개발자들 사이에서 약속된 코드 작성 규칙
//               코드의 가독성을 높이고 유지 보수를 쉽게 할 수 있음.
// 1. 식별자 표기법
//      - Pascal Case(파스칼 케이스) : 클래스, 함수, 프로퍼티 이름 등에 사용. 단어의 첫 글자는 대문자로
//                                     시작하며 이후 단어의 첫 글자도 대문자로 표기
//      - camel Case(카멜 케이스) : 변수, 매개변수, 로컬 변수 이름 등에 사용. 단어의 첫 글자는 소문자로
//                                  시작하며 이후 단어의 첫 글자는 대문자로 표기
//      - 대문자 약어 : 예외적으로 전체 글자가 모두 대문자인 식별자
// 2. 들여쓰기 : 탭(tab) 또는 스페이스(space) 4칸을 사용해 코드 블록을 들여씀
// 3. 중괄호 위치 : 중괄호({})는 항상 새로운 줄에서 시작
// 4. 빈 줄 사용 : 관련 없는 코드 사이에는 빈 줄을 사용해 구분. 메서드, 클래스 등의 블록 사이에는 두 줄을
//                 띄어 씀.
// 5. 주석 : // 한 줄 주석 사용, /**/ 여러 줄 주석을 사용할 때 /*를 다음 줄에서 시작하고 */를 새로운 줄에서
//           끝내도록 함