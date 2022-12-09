using System;
using System.Collections.Generic;

class NearAll
{
    static void Main()
    {
        int[] data = { 10, 20, 23, 27, 17 };
        int target = 25;
        List<int> nears = new List<int>();
        int min = Int32.MaxValue;

        for (int i = 0; i < data.Length; i++)
        {
            if (Math.Abs(data[i] - target) < min)
            {
                min = Math.Abs(data[i] - target);
            }
        }
        Console.WriteLine($"차이의 최솟값: {min}");

        for (int i = 0; i < data.Length; i++)
        {
            if (Math.Abs(data[i] - target) == min)
            {
                nears.Add(data[i]);
            }
        }

        foreach (var n in nears)
        {
            Console.WriteLine(n);
        }
    }
}