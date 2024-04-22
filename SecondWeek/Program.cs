namespace SecondWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20, num2 = 10;
            
            //산술 연산
            Console.WriteLine(num1 + num2);     // 30
            Console.WriteLine(num1 - num2);     // 10
            Console.WriteLine(num1 * num2);     // 200
            Console.WriteLine(num1 / num2);     // 2            
            Console.WriteLine(num1 % num2);     // 0

            Console.WriteLine();

            //관계 연산
            Console.WriteLine(num1 == num2);    // false
            Console.WriteLine(num1 != num2);    // true
            Console.WriteLine(num1 > num2);     // true
            Console.WriteLine(num1 < num2);     // false            
            Console.WriteLine(num1 >= num2);    // true
            Console.WriteLine(num1 <= num2);    // false

            Console.WriteLine();

            //논리 연산
            int num3 = 15;

            Console.WriteLine(0 <= num3 && num3 <= 20);     // 0과 20 사이에 포함되면 true
            Console.WriteLine(0 > num3 || num3 > 20);       // 0과 20 사이에 포함되지 않으면 true
                                                            // 아니므로 false
            Console.WriteLine(!(0 <= num3 && num3 <= 20));  // 0과 20 사이에 포함되지 않으면 true
                                                            // 이 조건에 한해 OR 연산과 동일한 결과 반환

            //비트 연산
            int a = 0b1100; // 12 (2진수)
            int b = 0b1010; // 10 (2진수)

            int and = a & b; // 0b1000 (8). &연산은 두 비트가 1인 경우 1, 아니면 0
            int or = a | b; // 0b1110 (14). |연산은 두 비트 중 1이 하나라도 있으면 1, 아니면 0
            int xor = a ^ b; // 0b0110 (6). ^연산은 두 비트가 서로 다르면 1, 같으면 0

            int c = 0b1011; // 11 (2진수)
            int leftShift = c << 2; // 0b101100 (44). 모든 비트들을 두 자리씩 왼쪽으로 이동.
            int rightShift = c >> 1; // 0b0101 (5). 모든 비트들을 한 자리씩 오른쪽으로 이동.
            //시프트 연산은 2를 곱하고 나누는 연산과 동일하다.

            int d = 0b1100; // 12 (2진수)
            int bit3 = (d >> 2) & 0b1; // 1 (3번째 비트)
            d |= 0b1000; // 0b1100 | 0b1000 = 0b1100 (12)

            // 문자열 생성
            string str1 = "Hello, World!";     // 리터럴 문자열 사용해서 문자열 생성
            string str2 = new string('H', 5);   // 'H' 문자를 5개 사용해서 문자열 생성

            // 문자열 연결
            str1 = "Hello";
            str2 = "World";
            string str3 = str1 + " " + str2;    // "Hello World" 저장

            // 문자열 분할(분리)
            string str = "Hello, World!";
            string[] words = str.Split(',');    // ','문자를 기준으로 str 문자열을 분리 후 문자열들을
                                                // 문자열 배열 words에 저장

            // 문자열 검색
            int index = str.IndexOf("World");   // str 문자열에서 World 문자열의 첫 index를 찾아 반환
                                                // 7 반환

            // 문자열 대체
            string newStr = str.Replace("World", "Universe");   // str 문자열에서 "World" 문자열을 
                                                                // "Universe" 문자열로 대체한 새로운 문자열
                                                                // newStr 생성

            // 문자열 변환
            str = "123";
            int num = int.Parse(str);       // 문자열 str을 정수형 숫자 123으로 변환 후 num에 저장

            num = 123;
            str = num.ToString();           // 정수형 숫자 123을 문자열 "123"으로 변환 후 str에 저장

            // 문자열 값 비교
            str1 = "Hello";
            str2 = "World";
            bool isEqual = (str1 == str2);      // str1과 str2가 같으면 true, 틀리면 false를 isEqual에 저장

            // 문자열 대소 비교
            str1 = "Apple";
            str2 = "Banana";
            int compare = string.Compare(str1, str2);   // 아무 옵션도 설정하지 않고 비교하는 경우 문자열을
                                                        // 사전식으로 비교하며 대소문자를 구분함
                                                        // 반환값이 0보다 작으면 str1 < str2
                                                        // 0이면 str1 == str2
                                                        // 0보다 크면 str1 > str2

            // 문자열 형식화
            string name = "John";
            int age = 30;
            string message = string.Format("My name is {0} and I'm {1} years old.", name, age);
            // name과 age를 각각 {0}, {1}에 넣어 문자열 반환
            // My name is John, and I'm 30 years old. 반환

            // 문자열 보간
            message = $"My name is {name} and I'm {age} years old.";
            // name과 age를 각각 {name}, {age}에 넣어 문자열 반환
            // My name is John, and I'm 30 years old. 반환
        }
    }
}

// 산술 연산자의 종류 : +(덧셈), -(뺄셈), *(곱셈), /(나눗셈), %(나머지)

// 관계 연산자의 종류 : ==(같음), !=(다름), >(큼), <(작음), >=(크거나 같음), <=(작거나 같음)

// 논리 연산자의 종류 : &&(논리곱, AND), ||(논리합, OR), !(논리부정, NOT)

// 비트 연산자의 종류 : &(AND), |(OR), ^(XOR), ~(NOT), <<(왼쪽 시프트), >>(오른쪽 시프트)

// 복합 대입 연산자의 종류 : +=(더하고 대입), -=(빼고 대입), *=(곱하고 대입), /=(나누고 대입), %=(나머지 대입)

// 증감 연산자의 종류 : ++(1 증가), --(1 감소)
//                      증감 연산자는 위치에 따라 전위(피연산자 앞), 후위(피연산자 뒤)로 나뉜다.

// 연산자 우선순위 : 수식 내에서 연산자가 수행되는 순서. 우선순위에 따라 연산의 결과가 달라질 수 있음.

// C#의 주요 연산자 우선순위
// 1. 소괄호() : 괄호로 감싸진 부분은 가장 높은 우선순위로 먼저 계산
// 2. 단항 연산자(++, --, +, -, ! 등)
// 3. 산술 연산자(* -> / -> % -> + -> -)
// 4. 시프트 연산자(<<, >>)
// 5. 관계 연산자(<, >, <=, >=, ==, !=)
// 6. 논리 연산자(&&, ||)
// 7. 할당(대입) 연산자(=, +=, -=, *=, /=, %= 등)