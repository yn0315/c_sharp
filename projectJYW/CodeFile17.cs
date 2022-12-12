using System;

class DelegateDemo
{
    static void Hi() => Console.WriteLine("안녕하세요.");
            //(void)반환형태가 같아야한다.
    delegate void SayDelegate();

    static void Main()
    {
        SayDelegate say = Hi;
        say();

        var hi = new SayDelegate(Hi);
        hi();
    }
}