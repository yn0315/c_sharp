using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
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

        //Process.Start("Notepad.exe");//메모장 열림
        //Process.Start("Explorer.exe","https://dotnetkorea.com");//인터넷창 열림

        string s = "안녕      반가워     또 만나";
        var regex = new Regex("\\s+");
        string r = regex.Replace(s, " ");
        WriteLine(s);
        WriteLine(r);
        // 정규식
        /*
         * \s 공백문자
         * \S 공백이 아닌 문자
         * \w 단어 문자
         * \W 단어가 아닌 문자
         * \d 10진수 숫자
         * \A 문자열의 시작
         * \z 문자열의 끝
         * 
         * + 앞에 지정한 문자가 연속 0개 이상
         * * 앞에 지정한 문자가 연속 1개 이상
         * {1,3} 괄호 앞에 문자가 연속 1개 이상, 3개 이하
         * 
         * 
         * 
         */
        //string email = "abc@aaa.com";
        //WriteLine(IsEmail(email));


        IsWhat(1234);
        IsWhat("hello");
        IsWhat(DateTime.Now);

        object x = 1234;
        string st = x as string;
        WriteLine(st == null? "null" : st);

        object stri = "반가워";
        string r1 = stri as string;
        WriteLine($"[1] {r1}");

        object i = 1234;
        string r2 = i as string;
        if (r2 == null)
            WriteLine("[2] null입니다.");

        object i2 = 3456;
        if (i2 is string)
        {
            string r3 = i2 as string;
            WriteLine($"[3]{r3}");
        }
        else
            WriteLine("[3]변환불가");

        string userName = "RedPlus";
        string userNameInput = "redPlus";

        if (userName.ToLower() == userNameInput.ToLower())
            WriteLine("[1]같다.");

        if (string.Equals(userName, userNameInput, StringComparison.InvariantCultureIgnoreCase))
            WriteLine("[2]같다.");


        var ss = "";
        ss = String.Empty;
        if (ss == null || ss == "")
            WriteLine($"{nameof(ss)}변수 값은 null또는 빈값입니다.");
        if (string.IsNullOrEmpty(ss))
            WriteLine($"{nameof(ss)}변수 값은 null또는 빈값입니다.");

        StringBuilder sb = new StringBuilder();

        sb.Append("january\n");
        sb.Append("february\n");
        sb.AppendLine("march");

        Write(sb);

        Write(sb.ToString());

        var message = new StringBuilder().AppendFormat("{0} 클래스를 사용한", nameof(StringBuilder))
            .Append("메서드").Append("체이닝").ToString().Trim();
        WriteLine(message);

        try
        {
            int[] arr = new int[2];
            arr[100] = 1234;
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }

        string inputNumber = "3.14";
        int number = 0;
        try
        {
            number = Convert.ToInt32(inputNumber);
            WriteLine($"입력한 값 : {number}");

        }
        catch (FormatException fe)
        {
            WriteLine($"에러발생 : {fe.Message}");
            WriteLine($"{inputNumber}는 정수여야 합니다.");
        }




        Environment.Exit(0);
        Write("출력안됨");


    }//end main

    static void Print(string name, int age) => Console.WriteLine($"이름: {name}, 나이: {age}");
    static void Print(Member member) => Console.WriteLine($"이름: {member.Name}, 나이: {member.Age}");


    


    static DateTime GetDateTimeFromYearlyHourNumber(int number)
    {
        return (new DateTime(2019, 1, 1, 0, 0, 0)).AddHours(--number);
    }

    static bool IsEmail(string email)
    {
        bool result = false;

        Regex regex = new Regex(@"^[A - Za - Z0 - 9](([_\n\-]?[a-zA-Z0-9]+)" + @"(([\n\-]?[a-zA-Z0-9]+)*)\.(A-Za-z]{2,})$");
        result = regex.IsMatch(email);
        return result;
    
    }

    static void IsWhat(object o)
    {
        if (o is int)
            WriteLine("Int");
        else if (o is string)
            WriteLine("String");
        else if (o is DateTime)
            WriteLine("DateTime");
    }
}



