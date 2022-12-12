using System;

class DelegateNote
{
    delegate void SayPointer();

    static void Hello() => Console.WriteLine("Hello Delegate");

    static void Main()
    {
        SayPointer sayPointer = new SayPointer(Hello);

        sayPointer();
        sayPointer.Invoke();
    }
}