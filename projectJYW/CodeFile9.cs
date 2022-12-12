using static System.Console;

class Developer
{
    public string Name { get; set; }//속성

    static void Main()
    {
        Developer developer = new Developer();
        developer.Name = "박용준";
        WriteLine(developer.Name);
        
    }
}
