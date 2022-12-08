using static System.Console;

class TryCatchFinallyDemo2
{
    static void Main()
    {
        int x = 5;
        int y = 0;
        int r;

        r = x / y;
        WriteLine($"{x} / {y} = {r}");
    }
}