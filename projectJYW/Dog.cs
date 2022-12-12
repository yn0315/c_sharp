using static System.Console;

public class Dog
{
    private string name;
    public Dog(string name)
    {
        this.name = name;
    }
    public string Cry()
    {
        return name + "이(가) 멍멍";
    }

    public static void Main()
    {
        Dog happy = new Dog("해피");
        WriteLine(happy.Cry());

        Dog worry = new Dog("워리");
        WriteLine(worry.Cry());
       

    }

}