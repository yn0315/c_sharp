using static System.Console;

public class Car
{
    private string[] names;

    public Car(int length)
    {
        names = new string[length];
    }
    public int Length
    {
        get { return names.Length; }

    }
    public string this[int index]
    { 
        get { return names[index]; }
        set { names[index] = value; }
    }

    static void Main()
    {
        Car car = new Car(3);
        car[0] = "CLA";
        car[1] = "CLS";
        car[2] = "AMG";

        for (int i = 0; i < car.Length; i++)
        {
            WriteLine("{0}", car[i]);
        }

    }
}