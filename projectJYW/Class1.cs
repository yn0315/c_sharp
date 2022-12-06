using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Random;
using static System.DateTime;
using System.Collections;
using System.Runtime.InteropServices;

namespace projectJYW
{
    //
    //2차원배열,3차원배열 
    //인형이 그려진 맵 표기

    //1. 인형배치방법
    //2. 회당 천원/ 12회 만원
    //인형 무게
    //집게의 힘
    //인형의 크기
    //집게 잘 집는 인형의 크기가 있어야 함
    //돈 많다 판단
    //플레이어 구분 - .....
    //어떻게 돈을 많이 뽑아낼 것인가
    //관리측면 주 1회 리필, 20개
    //3차원......
    //인형마다의 특성 = 등급
    //사용자입력 (readLine)
    //시간마다 일정량 뽑히게 해야함
    //총 매출금액/ 뽑힌 인형 정보 /예상 사용자 수/ 각 사용자가 사용한 금액
    class doll
    {
        static int count = 1; //횟수
        static int totalMoney = 0; //총수익
        static int money = 0;//한판마다 들어오는 수익
        static char[] pattern = new char[10];//움직임의 패턴
        static int[] dollWeight = { 100, 200, 300, 200, 100, 150, 250, 350, 400, 150, 250, 300, 100, 200, 200, 300, 200, 250, 300, 250, 400, 400 };
        static char[] dollName = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T' };
        
        static char[,,] place = {
        {{'C','E','I','M','Q'}},
        {{'B','F','J','N','R'}},
        {{'A','G','K','O','S'}},
        {{'D','H','L','P','T'}},
        };

        static int pin = 50;//집게의 무게 
        static char selDoll = ' '; //선택한 인형의 이름

        //인형 위치변수
        static int index_i = -1;
        static int index_j = -1;
        static int index_k = -1;

        //집게 위치변수
        static int pin_i = -1;
        static int pin_j = 0;
        static int pin_k = 0;

        
        static int c = 0;//pattern인덱스변수
        static bool t_or_f = false;// 집게가 내려가있으면 true

        static int weight = 0; //인형무게변수
        static char[] p = new char[10];//이전 패턴 저장하는 변수


        static int person = 1;
        //인형 자리배치 함수

        static char[,,] DollPlace()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {

                        if (i == 0)
                        {
                            
                            for (int x = 0; x < doll.dollWeight.Length; x++)
                            {
                                if (doll.dollWeight[x] > 150 && doll.dollWeight[x] < 300)
                                {
                                    doll.place[i, j, k] = doll.dollName[x];

                                    if (k == 4)
                                        break;
                                    else
                                        k++;
                                }
                            }
                        }

                        else if (i == 1)
                            
                        { //인형무게 150이하인 것들만 집어넣기
                            //place[i, j, k] = doll.dollName[k + 5];

                            for (int x = 0; x < doll.dollWeight.Length; x++)
                            {
                                if (doll.dollWeight[x] >= 100 && doll.dollWeight[x] <= 150)
                                {
                                    doll.place[i, j, k] = doll.dollName[x];

                                    if (k == 4)
                                        break;
                                    else
                                        k++;
                                }
                            }
                            /*
                            var row = j;
                            var col = k;
                            for (var x = 0; x < doll.dollWeight.Length; x++)
                            {

                                if (doll.dollWeight[x] >= 100 && doll.dollWeight[x] <= 150)
                                {
                                    place[1, 0, col] = doll.dollName[x];
                                    //WriteLine(doll.dollName[x]);
                                    col++;
                                }
                            }
                            */

                            //WriteLine(col);
                        }
                        else if (i == 2)

                        {

                            //place[i, j, k] = doll.dollName[k + 10];
                            for (int x = 14; x < doll.dollWeight.Length; x++)
                            {
                                if (doll.dollWeight[x] >= 200 && doll.dollWeight[x] <= 250)
                                {
                                    if (doll.place[i - 2, j, k] == doll.dollName[x]||doll.place[i - 1, j, k] == doll.dollName[x])
                                        continue;
                                    else
                                        doll.place[i, j, k] = doll.dollName[x];

                                    if (k == 4)
                                        break;
                                    else
                                        k++;
                                }
                            }
                        }
                        else if (i == 3)
                        //나머지
                        {
                            //place[i, j, k] = doll.dollName[k + 15];
                            for (int x = 0; x < doll.dollWeight.Length; x++)
                            {
                                if (doll.dollWeight[x] >= 300 && doll.dollWeight[x] <= 400)
                                {
                                    doll.place[i, j, k] = doll.dollName[x];

                                    if (k == 4)
                                        break;
                                    else
                                        k++;
                                }
                            }
                        }

                    }

                }
            } return place;
             
        }

        //프린트함수
        static void printPlace()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {

                        Write(place[i, j, k] + " ");

                    }
                    WriteLine();

                }
            }

        }

        static void indexOut(char selectdoll)
        {

            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (place[i, j, k] == selectdoll)
                        {
                            //place인덱스번호 추출
                            index_i = i;
                            index_j = j;
                            index_k = k;
                        }
                        else if (place[i, j, k] != selectdoll && place[i, j, k] == ' ')  
                        {

                            index_i = -1;
                            index_j = -1;
                            index_k = -1;
                        }
                    }
                }
            }
            


        }

        static void oneOrTwo()
        {
            int personCount = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                
                if (p[0] != 'a' && p[0] != 's' && p[0] != 'd' && p[0] != 'w')
                    person = 1;
                    


                if (p[i] == pattern[i])
                {
                    personCount++;
                    
                }
                else if (p[i] != pattern[i])
                {
                    personCount--;
                }

                if (personCount > 4)
                {
                    person = 1;
                }
              
            }
            if (personCount < 4)
                person++;
            

        }


        static void gameResult(int r)
        {
            if (r == 1)
            {
                WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                WriteLine("인형을 들어올립니다.");

                WriteLine("앗 팔이 집게에서 빠져나갑니다.");

                WriteLine("인형을 뽑았습니다. 축하합니다.");
                t_or_f = false;
                //해당인형 빼놓기
                doll.place[index_i, index_j, index_k] = ' ';
                pin_i = -1;

                WriteLine("p");
                oneOrTwo();

                for (int i = 0; i < 10; i++)
                {
                    p[i] = pattern[i];
                }

                Array.Clear(pattern, 0, 10);

                c = 0;

            }
            else if (r == 2)
            {
                WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                WriteLine("인형을 들어올립니다.");

                WriteLine("앗 다리가 집게에서 빠져나갑니다.");

                WriteLine("안타깝네요.");
                t_or_f = false;
                pin_i = -1;

                oneOrTwo();
                for (int i = 0; i < 10; i++)
                {
                    p[i] = pattern[i];
                }

                Array.Clear(pattern, 0, 10);

                c = 0;


            }
            else if (r == 3)
            {
                WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                WriteLine("인형을 들어올립니다.");

                WriteLine("앗 머리가 집게에서 빠져나갑니다.");

                WriteLine("안타깝네요.");
                t_or_f = false;
                pin_i = -1;

                oneOrTwo();
                for (int i = 0; i < 10; i++)
                {
                    p[i] = pattern[i];
                }

                Array.Clear(pattern, 0, 10);

                c = 0;

            }
            else
            {
                WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                WriteLine("인형을 들어올립니다.");

                WriteLine("앗 다리가 집게에서 빠져나갑니다.");

                WriteLine("안타깝네요.");
                t_or_f = false;
                pin_i = -1;

                oneOrTwo();
                for (int i = 0; i < 10; i++)
                {
                    p[i] = pattern[i];
                }

                Array.Clear(pattern, 0, 10);

                c = 0;

            }
            return;

        }

        static void game()
        {
            //집게의 힘을 올려라
            doll.pin = 200;
            
            DateTime f = DateTime.Now.AddSeconds(5);
            DateTime d = DateTime.Now;
            Random ran = new Random();
            int r = ran.Next(1, 8);

            while (true)
            {
                if (d >= f)
                {
                    WriteLine("시간이 다 되었습니다. 집게가 내려갑니다.");
                    if (index_i == pin_i && index_j == pin_j && index_k == pin_k)
                    {
                        //WriteLine("일치");

                        gameResult(r);

                    }
                    else
                    {
                        WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                        WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                        WriteLine("불일치");
                        WriteLine("인형을 찾을 수 없습니다.");
                        t_or_f = false;
                        oneOrTwo();
                        pin_i = -1;
                        WriteLine("p");

                        oneOrTwo();
                        for (int i = 0; i < 10; i++)
                        {
                            p[i] = pattern[i];
                        }

                        for (int i = 0; i < 10; i++)
  
                        Array.Clear(pattern, 0, 10);
                        c = 0;

                    }
                    break;

                }
                else
                {
                    WriteLine("w(↑),a(←),s(↓),d(→)");

                    
                    char position = Convert.ToChar(ReadLine());

                    pattern[c] = position;
                        
                    c++;


                    WriteLine(pattern);
                    if (position == 'a')
                    {
                        if (t_or_f == true)
                        {
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");
                            WriteLine("집게를 올려주세요.");

                            continue;
                        }
                        if (pin_k != 0)
                        {
                            pin_k--;
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");
                            WriteLine(pin_k);
                        }
                        else
                        {
                            pin_k = 0;
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");
                            WriteLine(pin_k);
                        }
                    }
                    else if (position == 's')
                    {

                        if (pin_i == -1)
                        {

                            if (index_i > 0)
                            {
                                if (place[index_i - 1, index_j, index_k] == ' ')
                                {
                                    pin_i = index_i;
                                }
                            }
                            else
                            {
                                pin_i++;
                            }
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");
                            WriteLine("집게가 내려갑니다.");
                            t_or_f = true;
                            
                        }
                        //좌우 움직이는 거 막아야함
                        else
                        {
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");
                            WriteLine("집게를 올려주세요.");
                            continue;
                        }

                    }
                    else if (position == 'd')
                    {
                        if (t_or_f == true)
                        {
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");
                            WriteLine("집게를 올려주세요.");
                            continue;
                        }

                        if (pin_k == 5)
                        {
                            pin_k = 5;
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                        }
                        else
                        {
                            pin_k++;
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");
                            WriteLine(pin_k);
                        }
                    }
                    else if (position == 'w')
                    {


                        if (t_or_f == true )
                        {
                            
                            if (index_i > 0)
                            {
                                if (place[index_i - 1, index_j, index_k] == ' ')
                                {
                                    pin_i = index_i;
                                }
                            }
                            else
                            {
                                pin_i = 0;
                            }
                            WriteLine("집게가 올라갑니다.");
                            


                            if (index_i == pin_i && index_j == pin_j && index_k == pin_k)
                            {
                                gameResult(r);
                                
                            }
                            else
                            {
                                
                                WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                                WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                                WriteLine("불일치");
                                WriteLine("이 위치가 아닙니다.");
                                t_or_f = false;
                                oneOrTwo();
                                pin_i = -1;


                                oneOrTwo();
                                for (int i = 0; i < 10; i++)
                                {
                                    p[i] = pattern[i];
                                }

                                Array.Clear(pattern, 0, 10);
                                c = 0;
                                
                            }
                            break;

                        }
                        else if(pin_i == -1)
                        {
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                            WriteLine("집게가 내려가지 않았습니다.");
                            continue;
                        }

                    }
                }

                d = DateTime.Now;

            }
        }

        static void Main()
        {
            DollPlace();
            

            while (true)
            {
                WriteLine("기계에 돈을 넣으면 뽑기를 시작합니다.");
                WriteLine("1. 돈 투입 2. 로그확인");
                string number = ReadLine();
                if (number == "1")
                {
                    Write("돈 입력 : ");

                    doll.money = Convert.ToInt32(ReadLine());
                    doll.totalMoney += doll.money;

                    if (Convert.ToInt32(doll.money / 1000) >= 10)
                    {
                        doll.count = Convert.ToInt32(Math.Truncate((doll.money / 1000) * 1.2));

                        for (int i = 0; i < count; i++)
                        {
                            WriteLine();
                            WriteLine($"게임을 시작합니다. 횟수 : {doll.count - i}번");
                            while (true)
                            {
                                WriteLine("인형을 골라주세요. 인형이름은 A ~ T까지 입니다.");
                                printPlace();
                                doll.selDoll = Convert.ToChar(ReadLine());
                                indexOut(doll.selDoll);
                                if (index_i == -1)
                                {
                                    WriteLine("해당 인형이 없습니다.");
                                    continue;
                                }
                                else
                                    break;
                            }
                            //게임시작
                            //인형을 고르면 함수에 집어 넣음
                            //함수는 고른 인형의 인덱스번호를 추출
                            //해당 인형의 무게 가져옴


                            Console.Clear();
                            WriteLine($"인형의 위치는 {index_i},{index_j},{index_k} 입니다.");
                            WriteLine($"집게의 위치는 {pin_i},{pin_j},{pin_k} 입니다.");
                            printPlace();
                            int b = Array.IndexOf(doll.dollName, doll.selDoll);
                            weight = doll.dollWeight[b];
                           

                            if (100 <= weight && weight <= 150)
                            {//인형의 무게가 100~ 150사이이면 집게의 힘을 올림(잘 집어지는 무게)

                                game();
                                pin_i = -1;
                                pin_j = 0;
                                pin_k = 0;
                                continue;

                            }
                            else if (150 <= weight)
                            {
                                game();
                                pin_i = -1;
                                pin_j = 0;
                                pin_k = 0;
                                continue;
                            }
                            
                        }


                    }
                    else if (Convert.ToInt32(doll.money / 1000) < 10)
                    {

                        
                        doll.count = Convert.ToInt32(doll.money / 1000);

                        for (int i = 0; i < count; i++)
                        {
                            WriteLine();
                            WriteLine($"게임을 시작합니다. 횟수 : {doll.count - i}번");
                            while (true)
                            {
                                WriteLine("인형을 골라주세요. 인형이름은 A ~ T까지 입니다.");
                                printPlace();
                                doll.selDoll = Convert.ToChar(ReadLine());
                                indexOut(doll.selDoll);
                                if (index_i == -1)
                                {
                                    WriteLine("해당 인형이 없습니다.");
                                    continue;
                                }
                                else
                                    break;
                            }
                            //게임시작
                            //인형을 고르면 함수에 집어 넣음
                            //함수는 고른 인형의 인덱스번호를 추출
                            //해당 인형의 무게 가져옴

                            Console.Clear();
                            WriteLine($"인형의 위치는 {index_i},{index_j},{index_k} 입니다.");
                            WriteLine($"집게의 위치는 {pin_i},{pin_j},{pin_k} 입니다.");
                            printPlace();
                            int b = Array.IndexOf(doll.dollName, doll.selDoll);
                            weight = doll.dollWeight[b];
                            


                            if (100 <= weight && weight <= 150)
                            {//인형의 무게가 100~ 150사이이면 집게의 힘을 올림(잘 집어지는 무게)

                                game();
                                pin_i = -1;
                                pin_j = 0;
                                pin_k = 0;
                                continue;

                            }
                            else if (150 <= weight)
                            {
                                game();
                                pin_i = -1;
                                pin_j = 0;
                                pin_k = 0;
                                continue;
                            }
                            
                        }

                    }

                }
                else if (number == "2")
                {
                    WriteLine($"총 수익 : {totalMoney}");
                    WriteLine($"게임 인원 : {person}");
                }

            }
        }

    }
}
