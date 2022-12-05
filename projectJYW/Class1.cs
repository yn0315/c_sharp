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
        static string[] pattern = new string[1000];//움직임의 패턴
        static string[] realPattern = new string[1000];
        static int[] dollWeight = { 100, 200, 300, 400, 100, 150, 250, 350, 400, 150, 250, 300, 100, 150, 150, 300, 200, 250, 300, 250, 400, 400 };
        static char[] dollName = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T' };
        static char[,,] place = {
        {{'C','E','I','M','Q'}},
        {{'B','F','J','N','R'}},
        {{'A','G','K','O','S'}},
        {{'D','H','L','P','T'}},

        };

        static int pin = 50;//집게의 무게 
        static int time = DateTime.Today.Hour; //한 시간 기준으로 뽑히게 만드는데 사용되는 변수
        static string selDoll = ""; //선택한 인형의 이름

        //인형 위치변수
        static int index_i = 0;
        static int index_j = 0;
        static int index_k = 0;

        //집게 위치변수
        static int pin_i = 0;
        static int pin_j = 0;
        static int pin_k = 0;


        static int c = 0;
        static bool t_or_f = false;

        static int weight = 0;
        static char[] p = new char[50];


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
                            for (int l = 0; l < doll.dollWeight.Length; l++)
                            {
                                if (doll.dollWeight[l] > 150 && doll.dollWeight[l] < 300)
                                {
                                    place[i, j, k] = doll.dollName[l];
                                    //인형무게 150 초과인 것들 집어넣기
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }

                        if (i == 1)
                        { //인형무게 150이하인 것들만 집어넣기

                            place[i, j, k] = doll.dollName[k + 5];

                        }
                        else if (i == 2)
                            //인형무게 150이하
                        {
                            place[i, j, k] = doll.dollName[k + 10];
                        }
                        else if (i == 3)
                            //나머지
                        {
                            place[i, j, k] = doll.dollName[k + 15];
                        }


                        Write(place[i, j, k]);


                    }
                    WriteLine();
                }
            } return place;

        }

        static void start(char a)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (place[i, j, k] == a)
                        {
                            //place인덱스번호 추출
                            index_i = i;
                            index_j = j;
                            index_k = k;
                        }
                    }
                }
            }


        }

        static void game()
        {
            //집게의 힘을 올려라
            doll.pin = 200;
            WriteLine(doll.pin);

            DateTime f = DateTime.Now.AddSeconds(5);
            DateTime d = DateTime.Now;
            Random ran = new Random();
            int r = ran.Next(1, 4);

            while (true)
            {
                if (d >= f)
                {
                    WriteLine("시간이 다 되었습니다. 집게가 내려갑니다.");
                    if (index_i == pin_i && index_j == pin_j && index_k == pin_k)
                    {
                        //WriteLine("일치");


                        if (r == 1)
                        {

                            WriteLine("인형을 들어올립니다.");

                            WriteLine("앗 팔이 집게에서 빠져나갑니다.");

                            WriteLine("인형을 뽑았습니다. 축하합니다.");
                        }
                        else if (r == 2)
                        {

                            WriteLine("인형을 들어올립니다.");

                            WriteLine("앗 다리가 집게에서 빠져나갑니다.");

                            WriteLine("안타깝네요.");
                        }
                        else if (r == 3)
                        {

                            WriteLine("인형을 들어올립니다.");

                            WriteLine("앗 머리가 집게에서 빠져나갑니다.");

                            WriteLine("안타깝네요.");
                        }
                        break;

                    }
                    else
                    {
                        WriteLine("불일치");
                        WriteLine("인형을 찾을 수 없습니다.");

                    }
                    break;

                }
                else
                {
                    WriteLine("w(↑),a(←),s(↓),d(→)");

                    
                    char position = Convert.ToChar(ReadLine());

                    p[c] = position;
                        
                    c++;


                    WriteLine(p);
                    if (position == 'a')
                    {
                        if (t_or_f == true)
                        {
                            WriteLine("집게를 올려주세요.");
                            continue;
                        }
                        if (pin_k != 0)
                        {
                            pin_k--;
                            WriteLine(pin_k);
                        }
                        else
                        {
                            pin_k = 0;
                            WriteLine(pin_k);
                        }
                    }
                    else if (position == 's')
                    {

                        if (pin_i == 0)
                        {
                            pin_i--;
                            WriteLine("집게가 내려갑니다.");
                            t_or_f = true;
                        }
                        //좌우 움직이는 거 막아야함
                        else
                        {
                            WriteLine("집게를 올려주세요.");
                            continue;
                        }

                    }
                    else if (position == 'd')
                    {
                        if (t_or_f == true)
                        {
                            WriteLine("집게를 올려주세요.");
                            continue;
                        }

                        if (pin_k == 5)
                        {
                            pin_k = 5;

                        }
                        else
                        {
                            pin_k++;
                            WriteLine(pin_k);
                        }
                    }
                    else if (position == 'w')
                    {


                        if (t_or_f == true)
                        {
                            pin_i = 0;
                            WriteLine("집게가 올라갑니다.");
                            WriteLine($"인형위치: {index_i},{index_j},{index_k}");
                            WriteLine($"집게위치: {pin_i},{pin_j},{pin_k}");

                            //집게 위치확인 및 인형 뽑힐지 안 뽑힐지 여부 확인 함수실행.........

                            if (index_i == pin_i && index_j == pin_j && index_k == pin_k)
                            {

                                if (r == 1)
                                {

                                    WriteLine("인형을 들어올립니다.");

                                    WriteLine("앗 팔이 집게에서 빠져나갑니다.");

                                    WriteLine("인형을 뽑았습니다. 축하합니다.");
                                    t_or_f = false;
                                }
                                else if (r == 2)
                                {

                                    WriteLine("인형을 들어올립니다.");

                                    WriteLine("앗 다리가 집게에서 빠져나갑니다.");

                                    WriteLine("안타깝네요.");
                                    t_or_f = false;
                                }
                                else if (r == 3)
                                {

                                    WriteLine("인형을 들어올립니다.");

                                    WriteLine("앗 머리가 집게에서 빠져나갑니다.");

                                    WriteLine("안타깝네요.");
                                    t_or_f = false;
                                }
                                break;

                            }
                            else
                            {
                                WriteLine("불일치");
                                WriteLine("인형을 찾을 수 없습니다.");
                                t_or_f = false;
                            }
                            break;

                            

                        }
                        else
                        {
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

            char[,,] s = DollPlace();
            WriteLine(s);


            WriteLine("기계에 돈을 넣으면 뽑기를 시작합니다.");
            WriteLine("1. 돈 투입 2. 로그확인");
            string number = ReadLine();
            if (number == "1")
            {
                Write("돈 입력 : ");

                doll.money = Convert.ToInt32(ReadLine());
                doll.totalMoney += doll.money;

                if (doll.money / 1000 >= 10)
                {
                    doll.count = Convert.ToInt32(Math.Truncate((doll.money / 1000) * 1.2));


                    for (int i = 0; i < count; i++)
                    {
                        WriteLine($"게임을 시작합니다. 횟수 : {doll.count - i}번");
                        WriteLine("인형을 골라주세요. 인형이름은 A ~ T까지 입니다.");
                        char a = Convert.ToChar(ReadLine());
                        start(a);
                        //게임시작
                        //인형을 고르면 함수에 집어 넣음
                        //함수는 고른 인형의 인덱스번호를 추출
                        //해당 인형의 무게 가져옴
                        WriteLine($"인형의 위치는 {index_i},{index_j},{index_k} 입니다.");
                        WriteLine($"집게의 위치는 {pin_i},{pin_j},{pin_k} 입니다.");
                        int b = Array.IndexOf(doll.dollName, a);
                        weight = doll.dollWeight[b];
                        WriteLine(weight);


                        if (100 <= weight && weight <= 150)
                        {//인형의 무게가 100~ 150사이이면 집게의 힘을 올림(잘 집어지는 무게)

                            game();
                            return;

                        }
                        else if (150 <= weight)
                        {
                            game();
                            return;
                        }

                    }

                    //한 시간마다 한번씩 온전히 뽑히게 함



                    //동일인인지 판별여부
                    //같은 인형을 뽑는지

                    //패턴파악



                }
                //else if()

            }
            else if (number == "2")
            {
                WriteLine($"총 수익 : {totalMoney}");
            
            }

        }

    
         


            







     

    }
}
