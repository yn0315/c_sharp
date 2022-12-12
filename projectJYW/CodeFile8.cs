using static System.Console;

public class Messenger
{
    public void PrintMessage(string message, string prefix = "", string suffix = "")
    {
        WriteLine($"{prefix}{message}{suffix}");

    }


    static void Main()
    {
        Messenger messenger = new Messenger();
        messenger.PrintMessage("My");
        messenger.PrintMessage(prefix: "Oh ", message: "My");
        messenger.PrintMessage(prefix: "Oh " ,message: "My " ,suffix: "God");
    }
}