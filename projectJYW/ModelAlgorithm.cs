using System;
using System.Linq;

class ModeAlgorithm
{
    static void Main()
    {
        int[] scores = { 1, 3, 4, 3, 5 };
        int[] indexes = new int[5 + 1];
        int max = int.MinValue;
        int mode = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            indexes[scores[i]]++;
        }
        for (int i = 0; i < indexes.Length; i++)
        {
            if (indexes[i] > max)
            {
                max = indexes[i];
                mode = i;
            }
        }

        Console.WriteLine($"최빈값(문) : {mode} -> {max}번 나타남");
        var q = scores.GroupBy(v => v).OrderByDescending(g => g.Count()).First();
        int modeCount = q.Count();
        int frequency = q.Key;
        Console.WriteLine($"최빈값(식) : {frequency} -> {modeCount}번 나타남");
    }
}