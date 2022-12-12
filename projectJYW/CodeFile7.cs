using static System.Console;

class ParamsDemo
{
    static void Main()
    {
        WriteLine(SumAll(3,5));
        WriteLine(SumAll(3,5,7));
        WriteLine(SumAll(3,5,7,9));

    }
    static int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += sum;
        }
        return sum;
    }
}