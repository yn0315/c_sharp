using System;
using System.Linq;
using static System.Console;

class NearAlgorithm
{
    static void Main()
    {
        int Abs(int number) => (number < 0) ? -number : number;

        int min = int.MaxValue;
        

        int[] numbers = { 0b1010, 0x14, 0b11110, 0x1B, 0b10001 };
        int target = 25;
        int near = default;

        for (int i = 0; i < numbers.Length; i++)
        {
            int abs = Abs(numbers[i] - target);
            if (abs < min)
            {
                min = abs;
                near = numbers[i];

            }
        }

        var minimum = numbers.Min(m => Math.Abs(m - target));
        var closest = numbers.First(c => Math.Abs(target - c) == minimum);
        WriteLine($"{target}과 가장 가까운 값(식) : {closest}(차이 : {minimum})");
        WriteLine($"{target}과 가장 가까운 값(문) : {near}(차이 : {min})");
    }
}