using System;
class Say
{
    private string message = "안녕";

    public void Hi()
    {
        this.message = "반갑";
        Console.WriteLine(this.message);
    }

}

class FieldInitializer
{
    static void Main()
    {   
        Say say = new Say();
        say.Hi();
    }
}