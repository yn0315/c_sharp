using System;
using static System.Console;

class algorithm
{
    static void Main()
    {
        /*
        var data = Enumerable.Repeat(3, 5);
        var result = data.Distinct();
        foreach (var item in result)

            WriteLine(item);

        int[] arr = { 2, 2, 3, 3, 3 };

        WriteLine(arr.Distinct());
        */
        /*
        var colors = new List<string> { "Red", "Green", "Blue" };
        var newColors = colors.Where(c => c.Contains("e"));
        foreach(var color in newColors)
            WriteLine(color);

        var green = colors.Where(c => c.Contains("ee"));
        foreach(var c in green)
            WriteLine(c);
        */

        List<string> colors = new List<string> { "Red","Green","Blue"};
        string red = colors.Single(c => c == "Red");
        WriteLine(red);

        //string black = colors.Single(color => color == "Black");
        string black = colors.SingleOrDefault(color => color == "Black");
        WriteLine(black);

        int[] arr = { 1, 2, 3, 4, 5 };
        var evenNumbers = 
            from num in arr
            where num % 2 == 0
            select num;

        foreach (var number in evenNumbers)
        {
            WriteLine($"짝수: {number}" );
        }


    }

}