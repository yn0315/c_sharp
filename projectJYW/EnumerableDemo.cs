using System;
using System.Linq;

class EnumerableDemo
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 5);
        foreach (var n in numbers)
        {
            Console.WriteLine("{0}\t",n);

        }
        Console.WriteLine();

        var samenumbers = Enumerable.Repeat(-1, 5);
        foreach (var n in samenumbers)
        {
            Console.WriteLine("{0}\t", n);

        }
        Console.WriteLine();
        
        /////////////////////////람다
        Func<int, bool> isEven = x => x % 2 == 0;
        isEven(2);
        isEven(3);
        Action<string> greet = name => { var message = $"hello {name}"; Console.WriteLine(message); };
        greet("you");

        ///////where메서드
        /*
        int[] numberss = { 1, 2, 3, 4, 5 };
        IEnumerable<int> numbers2 = numberss.Where(nember => number > 3);
        foreach (var n in numbers2)
        {
            Console.WriteLine(n);
        }
        */



    }
}