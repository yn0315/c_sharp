using static System.Console; 
    
public class Nam
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Color { get; set; }

    static void Main()
    { 
        Nam c1 = new Nam();
        c1.Name = "남보러가니";
        WriteLine(c1.Name);

        Nam c2 = new Nam();
        c2.Name = "제네실수";
        c2.Color = "Red";
        WriteLine("{0},{1}", c2.Name, c2.Color);
    }
}