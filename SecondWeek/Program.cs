namespace SecondWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //-자동 완성 기능을 사용하여 코드 작성 시간을 단축하는 방법
            //1.클래스, 메서드, 변수 등의 이름을 입력할 때 일부를 입력하고, Tab 키를 눌러 나머지를 자동 완성합니다.
            //-Console.WriteLine을 작성할 때, Console.까지 입력하고 Tab 키를 누르면 자동으로 WriteLine이 완성됩니다.
            Console.WriteLine("C#");
            //-메서드나 변수를 입력하는 도중에 Ctrl +Space를 눌러 IntelliSense를 호출하면, 해당 메서드나 변수에 대한 정보와 예제를 볼 수 있습니다.
            Console.WriteLine("Study");
            //2.코드 템플릿을 사용하여 코드를 더 빠르게 작성합니다.
            //-예를 들어, for문을 작성할 때, for 키워드를 입력하고, 두 번 Tab 키를 누르면 for문의 기본적인 코드 템플릿이 자동으로 생성됩니다.
            for (int i = 0; i < 10; i++) { }
        }
    }
}

//1.빌드하기
//    - Visual Studio의 메뉴 > Build > Build Solution을 선택해 빌드합니다.
//    - 빌드가 성공적으로 완료되면, Output(출력) 창에서 빌드 메시지를 확인할 수 있습니다.

//2. 실행하기
//    - 디버그 메뉴 > Start Without Debugging을 선택해 프로그램을 실행합니다.
//    - 콘솔 애플리케이션인 경우, 콘솔 창이 열리고 프로그램이 실행됩니다.
//    - 윈도우 애플리케이션인 경우, 애플리케이션 창이 열리고 프로그램이 실행됩니다.