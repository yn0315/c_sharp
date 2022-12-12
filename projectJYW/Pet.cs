using static System.Console;

class Pet
{
    private string _name;

    public Pet(string name) => _name = name;
    public override string ToString()
    {
        return _name;
    }


    static void Main()
    {
        var pet = new Pet("야옹이");
        WriteLine(pet.ToString());
    }
}