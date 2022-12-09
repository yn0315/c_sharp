﻿using static System.Console;

class SelectinSort
{
    //퀵정렬
    //선택정렬 : 예제쓰기
    //버블정렬
    //병합정렬
    //코드작성 각정렬의 구동방식
    static void Main()
    {
        //선택정렬
        int[] data = { 3, 2, 1, 5, 4 };
        int N = data.Length; //회전 길이변수

        for (int i = 0; i < N - 1; i++) //N -1 만큼 회전을 한다.
        {
            for (int j = i + 1; j < N; j++) //i는 회전할 때마다 1씩 늘어나고 j 는 그 다음자리부터 회전한다. 
            {
                if (data[i] > data[j]) //앞이 뒤보다 크면
                {
                    int temp = data[i];//임시 변수에 앞에 데이터를 저장한다.
                    data[i] = data[j]; //앞에 데이터 [i]에는 뒤에 데이터[j]를 저장한다.
                    data[j] = temp;//뒤에 데이터에는 앞의 데이터를 저장함으로써 앞뒤 데이터를 바꾸는 작업을 마무리한다.
                }
            }
        }

        for (int i = 0; i < N; i++)
        {
            Write($"{data[i]}\t");
        }
        WriteLine();
    }
}