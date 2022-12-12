using static System.Console;

namespace DelegatePractice
{
    public class CarDriver
    {
        public static void GoForward() => WriteLine("직진");
        public static void GoLeft() => WriteLine("좌회전");
        public static void GoRight() => WriteLine("우회전");


    }
    public class Insa
    {
        public void Bye() => WriteLine("잘가");

    }
    public delegate void GoHome();
    public class DelegatePractice
    {
        public delegate void Say();

        private static void Hello()
        {
            WriteLine("hello");
        }
        private static void Hi()
        {
            WriteLine("Hi");
        }

        static void Main()
        {
            CarDriver.GoLeft();
            CarDriver.GoForward();
            CarDriver.GoRight();

            GoHome go = new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoLeft);
            go -= new GoHome(CarDriver.GoLeft);
            go();

            WriteLine();

            Say say;
            say = new Say(Hi);
            say += new Say(Hello);
            say();

            Insa insa = new Insa();
            Say say2 = new Say(insa.Bye);
            say2 += new Say(insa.Bye);
            say2();

        }
    }
}