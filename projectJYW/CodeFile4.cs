using static System.Console;

class TryCatchFinallyDemo3
{
    static void Main()
    {
        int x = 5;
        int y = 0;
        int r;

        try
        {
            r = x / y;
            WriteLine($"{x}/{y} = {r}");
        }
        catch
        {
            WriteLine("예외발생");
        }
        finally
        {
            WriteLine("종료");
        }
    }

}