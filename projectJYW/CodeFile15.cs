using static System.Console;
class Catalog
{
    public string this[int index]
    {
        get
        {
            return (index % 2 == 0 )? $"{index} : 짝수반환" : $":{ index} : 홀수반환";
        }
    }
}
class IndexerNote
{
    static void Main()

    {
        Catalog catalog = new Catalog();
        WriteLine(catalog[0]);
        WriteLine(catalog[1]);
        WriteLine(catalog[2]);
    }
}