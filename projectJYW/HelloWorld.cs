using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
using System.Diagnostics;
using System.Threading;
class SignedInteger

{
    static string message = "전역변수";
    static void show() // 클래스 안에 있으므로 함수는 위, 아래 아무데나 작성해도 괜찮다.
    {
        WriteLine("hello world");
    }
    static int GetInt(int x)
    {
        int r = x * x;
        return r;
    }

    static int Max(int x, int y)
    {
        return(x > y )? x : y;  
    }

    static int Min(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    static void GetNumber(int number)
    {
        WriteLine($"Int32: {number}");

    }
    static void GetNumber(long number)
    {
        WriteLine($"Int64: {number}");

    }

    static int MyPower(int num, int cnt)
    {
        if (cnt == 0)
        {
            return 1;

        }
        return num * MyPower(num, --cnt);
    }

    static void ShowMessage()
    {
        string message = "지역변수";
        WriteLine(message);
    }



    static void Main()
    {
        show();
        int returnValue = GetInt(3);
        WriteLine(returnValue);

        WriteLine(Max(3, 5));
        WriteLine(Min(-3, -5));

        GetNumber(1234);
        GetNumber(1234L);
        WriteLine(MyPower(2, 2));

        ShowMessage();
        WriteLine(message);
        ///////////////////////////////////////////////////////////////////////
        Write("이번주의 로또 : ");
        Random ran = new Random();
        int[] arr = new int[6];
        int temp = 0;
        for (int i = 0; i < 6; i++)
        {
            temp = ran.Next(45) + 1;
            bool flag = false;
            if (i > 0 && i < 6)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == temp)
                    {
                        flag = true;
                    }
                
                }
            }
            if (flag)
            {
                --i;
            }
            else
            {
                arr[i] = temp;
            }
        }
        for (int i = 0; i < 6; i++)
        {
            Write("{0} ", arr[i]);
        }
        WriteLine();

        ////////////////////////////////////////////////////////////

        int iRandom = 0;
        int iSelection = 0;
        string[] choice = { "가위", "바위", "보" };
        iRandom = (new Random()).Next(1, 4);
        Write("1가위 2바위 3보 입력 : _\b");
        iSelection = Convert.ToInt32(ReadLine());
        WriteLine("\n사용자 : {0}", choice[iSelection - 1]);
        WriteLine("\n컴퓨터 : {0}\n", choice[iRandom - 1]);
        if (iSelection == iRandom)
        {
            WriteLine("비김");
        }
        else
        {
            switch (iSelection)
            {
                case 1: WriteLine((iRandom == 3) ? "승" : "패");break;
                case 2: WriteLine((iRandom == 1) ? "승" : "패");break;
                case 3: WriteLine((iRandom == 2) ? "승" : "패");break;
            }
        }

        /////////////////////////////////////////////////////////////
        
        Stopwatch timer = new Stopwatch();
        timer.Start();
        LongTimeProcess();
        timer.Stop();

        //밀리초단위로 표시
        WriteLine("경과시간 : {0} 밀리초", timer.Elapsed.TotalMilliseconds);

        //초단위로 표시
        WriteLine("경과시간: {0} 초", timer.Elapsed.Seconds);

        static void LongTimeProcess()
        {
            //3초간 대기 : Tread.Sleep()
            Thread.Sleep(3000);
         }

        //int number;
        //number = 7;

        //Console.WriteLine(number);
        ///*
        //* 범위주석
        //*/

        ////값 자체를 리터럴이라고 함
        //Console.WriteLine(1234);
        //Console.WriteLine(3.14F);
        //Console.WriteLine('A');
        //Console.WriteLine("HELLO");

        //Console.WriteLine("{0}", number); //7
        //int a, b, c;
        //a = b = c = 3;

        //sbyte iSByte = 127;
        //short iInt16 = 32767;
        //int iInt32 = 2147483647;
        //long iInt64 = 9223372036854775807;

        //Console.WriteLine("8비트 sbyte : {0}", iSByte);
        //Console.WriteLine("16비트 sbyte : {0}", iInt16);
        //Console.WriteLine("32비트 sbyte : {0}", iInt32);
        //Console.WriteLine("64비트 sbyte : {0}", iInt64);
        //Console.WriteLine(Console.ReadLine());//ReadLine =input()

        ////108예제
        //double d = 12.34;
        //int i = 1234;
        //d = i;
        //Console.WriteLine("암시적 형식변환 = " + d);

        //d = 12.34;
        //i = (int)d;
        //Console.WriteLine("명시적 형식변환 = " + d);

        //string s = "";
        //s = Convert.ToString(d);
        //Console.WriteLine("형식변환 = " +  s);
        //Console.WriteLine("아무키나 누르세요.");
        //ConsoleKeyInfo cki = Console.ReadKey(true);
        //Console.WriteLine("{0}", cki.Key);
        //Console.WriteLine("{0}", cki.KeyChar);
        //Console.WriteLine("{0}", cki.Modifiers);
        //if (cki.Key == ConsoleKey.Q)
        //{
        //    Console.WriteLine("Q를 입력하셨군요.");
        //}
        // (-) 연산자 : 부호를 바꿔서 출력

        //변환연산자 () 기호로 데이터 형식 변환
        //(int)3.14

        //문자열 연결 연산자 + 
        //문자열끼리 +연산 가능
        //"A" + " " + "C"

        //대입연산자 = ,+=,-=...

        //증감연산자 ++, --

        //전위 증감연산자: ++a
        //후위 증감연산자:a++

        //&& : and
        //|| : or
        //! : not

        //비트연산자
        //& :and
        //| : or
        //^ : xor
        //~ : not

        //시프트연산자
        //<<왼쪽으로 시프트해라
        //>>오른쪽으로 시프트해라
        //시프트연산자를 통해 비트의 자리이동가능


        //byte num1 = 4;
        //num1 &= 5;
        //Console.WriteLine(num1);

        //byte num2 = 4;
        //num2 |= 1;
        //Console.WriteLine(num2);

        //byte num3 = 4;
        //num3 ^= 2;
        //Console.WriteLine(num3);

        //byte num4 = 4;
        //num4 <<= 1;
        //Console.WriteLine(num4);

        //byte num5 = 4;
        //num5 >>= 1;
        //Console.WriteLine(num5);

        ////조건연산자

        //int number = 3;
        //string result = (number % 2 == 0) ? "짝수" : "홀수";

        //Console.WriteLine($"{number}는(은) {result}입니다.");
        /*
        string data = "1234";
        int result;
        if (int.TryParse(data, out result))
        {
            Console.WriteLine("변환가능 : {0}", result);
        }
        else
        {
            Console.WriteLine("변환불가");
        }
        double d;
        if (double.TryParse(data, out d))
        {
            Console.WriteLine("변환가능 : {0}",result);
        }

        if (double.TryParse("3.14", out var r)) //r이라는 변수를 만들어서 그 결과를 r에 넣는다. T or F를 반환
        {
            Console.WriteLine($"{r} : {r.GetType()}");

        }
        else
        {
            Console.WriteLine("변환불가");
        }

        */
        /*
        WriteLine("가장 좋아하는 프로그래밍 언어는?");
        Write("1.C\t");
        Write("2.C++\t");
        Write("3.C#\t");
        Write("4.java\t");

        int choice = Convert.ToInt32(ReadLine());

        switch (choice)
        {
            case 1:
                WriteLine("C선택");
                break;
            case 2:
                WriteLine("C++선택");
                break;
            case 3:
                WriteLine("C#선택");
                break;
            case 4:
                WriteLine("java선택");
                break;
            default:
                WriteLine("C,C++,java가 아니군요.");
                break;

        }
        */
        /*
        string[] names = { "C#", "ASP.NET" };
        foreach (string name in names)
        {
            WriteLine(name);    
        }

        string str = "ABC123";

        foreach (char c in str)
        {
            Write($"{c}\t");
        }

        WriteLine();
   
        */

        //배열
        //식별자 하나로 여러개의 같은 데이터 타입 묶음
        //컬렉션
        //1.배열 2. 리스트 3. 딕셔너리

        /*
        //배열미리보기샘플
        var array = new string[] { "Array", "List", "Dictionary" };
        foreach (var arr in array) { WriteLine(arr); }

        //리스트미리보기샘플
        var list = new List<string> {"Array","List","dictionary" };
        foreach (var item in list) { WriteLine(item); }

        //사전미리보기샘플
        var dictionary = new Dictionary<int, string> 
        {{0,"Array" },{1,"list"},{2,"Dictionary"}};
        foreach(var pair in dictionary)
        {
            WriteLine($"{pair.Key}-{pair.Value}");

        }
        */

        //string[] languages = { "korean", "english", "spanish" };
        //WriteLine($"{languages[0]}, {languages[1]}, {languages[2]}");

        /*
        //231예제
        char[,] arr = new char[2, 2];
        arr[0, 0] = 'A';
        arr[0, 1] = 'B';
        arr[1, 0] = 'C';
        arr[1, 1] = 'D';

        WriteLine($"{arr[0, 0]},{arr[0, 1]}");
        WriteLine($"{arr[1, 0]},{arr[1, 1]}");

        //232예제
        int[,] intArray;
        intArray = new int[2, 3];

        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;
        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Write($"{intArray[i, j]}_");
            }

            Write("\n");
        }
        */
        /*
        //238예제
        int[,,] intArray = new int[2, 3, 4]
            {
            {{1,2,3,4 },{5,6,7,8 },{9,10,11,12 } },
            {{13,14,15,16 },{17,18,19,20 },{21,22,23,24 } }
            };

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Write("{0,2} ", intArray[i, j, k]);
                }
                Write("\n");   
            }
            WriteLine();
        }

        //239예제
        int[,,] arr = new int[2, 2, 2]
            {{ {1,2 },{3,4 } },{ {5,6 },{7,8 } } };
        WriteLine("차수 출력: {0}", arr.Rank);
        WriteLine("길이 출력: {0}", arr.Length);

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Write("{0}\t", arr[i, j, k]);

                }
                WriteLine();
            }

            WriteLine();
        }

        */
        /*
        int[][] zagArray = new int[2][];

        zagArray[0] = new int[] { 1, 2 };
        zagArray[1] = new int[] { 3, 4 ,5};

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < zagArray[i].Length; j++)
            {
                Write($"{zagArray[i][j]}\t");
            }
            WriteLine();
        }

        WriteLine();

        */




    }

} 
