using System;


namespace Foo
{
    public class Car
    {
        public void Go() => Console.WriteLine("[1] Bar 네임스페이스의 Car");
    }

    
}

namespace Bar
{
    public class Car
    {
        public void Go() => Console.WriteLine("[2] Bar 네임스페이스의 Car");
    }
}

class NamespaceNote
{
    static void Main()

    {
    
        Foo.Car fooCar = new Foo.Car();
        fooCar.Go();
        Bar.Car barCar = new Bar.Car();
        barCar.Go();
    }
}