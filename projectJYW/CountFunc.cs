using System;
using System.Linq;

class CountFunc
{
    static void Main()
    {
        bool[] blns = { true, false, true, false, true };

        Console.WriteLine(blns.Count());
        Console.WriteLine(blns.Count(bln => bln == true));
        Console.WriteLine(blns.Count(bln => bln == false));
    }
}