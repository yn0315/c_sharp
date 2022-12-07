using System;
using static System.Console;

struct Point
{
    public int x;
    public int y;

}

struct Doll
{
    public string name;
    public int weight;
    public string size;

    
}

struct Member
{
    public string Name;
    public int Age;
}

enum Animal {Rabbit, Dragon, Snake}
class GetDateTimeFromYearlyHour
{
    //인형의 이름/무게(100 ~ 500)/ 사이즈(s,m,l)을 담는 구조체를 만들고
    //인형 5개의 정보를 사용자입력으로 받아 저장, 구조체 타입의 배열로 만들어라.
    static void Main()
    {
        Point point;
        point.x = 100;
        point.y = 200;
        Console.WriteLine($"x : {point.x} y : {point.y}");

        Doll doll;

        Doll[] dolls = new Doll[5];
        /*
        for (int i = 0; i < 5; i++)
        {
            WriteLine("이름");
            dolls[i].name = ReadLine();
            WriteLine("무게");
            dolls[i].weight = Convert.ToInt32(ReadLine());
            WriteLine("사이즈");
            dolls[i].size = ReadLine();


        }
        */
        

        string name = "백승수";
        int age = 21;
        Print(name, age);

        Member m;
        m.Name = "이세영";
        m.Age = 100;
        Print(m);

        //296예제
        WriteLine(GetDateTimeFromYearlyHourNumber(1));
        WriteLine(GetDateTimeFromYearlyHourNumber(8760 / 2));
        WriteLine(GetDateTimeFromYearlyHourNumber(8760));

        ForegroundColor = ConsoleColor.Blue;
        WriteLine("Blue");
        ResetColor();
        BackgroundColor = ConsoleColor.Yellow;
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Red");
        ResetColor();

        Animal animal = Animal.Dragon;
        //숫자가 배정되어 있다.
        int num = (int)animal;
        string str = animal.ToString();
        WriteLine($"Animal.Dragon : {num}, {str}");


        Type cc = typeof(ConsoleColor);
        string[] colors = Enum.GetNames(cc);

        foreach (var color in colors)
        {
            WriteLine(color);
        }

        String c = "Red";

        //스트링이 아니라 실제 값을 넣어줘야함
        ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), c);

        WriteLine("Red");
        ResetColor();

        Environment.Exit(0);
        WriteLine("출력안됨");
    }

    static void Print(string name, int age) => Console.WriteLine($"이름: {name}, 나이: {age}");
    static void Print(Member member) => Console.WriteLine($"이름: {member.Name}, 나이: {member.Age}");


    


    static DateTime GetDateTimeFromYearlyHourNumber(int number)
    {
        return (new DateTime(2019, 1, 1, 0, 0, 0)).AddHours(--number);
    }
}



