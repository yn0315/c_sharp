using static System.Console;

class ParameterOUt
{
    static void Main()
    {
        int num;
        Do(out num);//그릇을 줄테니 반환해라
        WriteLine($"[2] {num}");
    }
    static void Do(out int num)
    {
        num = 1234;
        WriteLine($"[1] {num}");
    }
}