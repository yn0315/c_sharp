using System.Threading.Tasks.Dataflow;
using static System.Console;

class ExceptionHandling
{
    static void Main()
    {
        int a = 3;
        int b = 0;

        try
        {
            a = a / b;

        }
        catch (Exception ex)
        {
            WriteLine($"예외(에러) 발생 : {ex.Message}");
        }
        finally
        {
            WriteLine("try구문을 정상종료");
        }

        try
        {
            throw new Exception("내가 만든 에러");
        }
        catch (Exception e)
        {
            WriteLine($"예외발생: {e.Message}");
        }
        finally
        {
            WriteLine("try구문 정상 종료");
        }
    }
}