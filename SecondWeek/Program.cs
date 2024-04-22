namespace SecondWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 1
            //string name, age;

            //Console.Write("이름을 입력하세요. : ");
            //name = Console.ReadLine();
            //Console.Write("나이를 입력하세요. : ");
            //age = Console.ReadLine();

            //Console.WriteLine("안녕하세요, {0}! 당신은 {1} 세 이군요.", name, age);

            // 1 - 2
            //int first, second;

            //Console.Write("첫번째 수를 입력하세요. : ");
            //first = int.Parse(Console.ReadLine());
            //Console.Write("두번째 수를 입력하세요. : ");
            //second = int.Parse(Console.ReadLine());

            //Console.WriteLine("더하기 : {0}", (first + second));
            //Console.WriteLine("빼기 : {0}", (first - second));
            //Console.WriteLine("곱하기 : {0}", (first * second));
            //Console.WriteLine("나누기 : {0}", ((float)first / second));

            // 1 - 3
            //int input;

            //Console.Write("섭씨 온도를 입력하세요. : ");
            //input = int.Parse(Console.ReadLine());

            //Console.WriteLine("변환된 화씨 온도 : {0}", (input * (9f / 5f)) + 32);

            // 1 - 4
            int kg, height;
            float mHeight;

            Console.Write("체중을 입력해주세요. : ");
            kg = int.Parse(Console.ReadLine());
            Console.Write("키를 입력해주세요. : ");
            height = int.Parse(Console.ReadLine());

            mHeight = (float)height / 100f;

            Console.WriteLine("BMI 지수 : {0}", kg / (mHeight * mHeight));
        }
    }
}
