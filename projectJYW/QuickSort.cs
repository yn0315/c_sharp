using System;


class QuickSort
{
    static void Main(string[] args)
    {
        int[] nArr = new int[] { 1, 4, 3, 5, 9, 6, 2, 7, 8, 10 };

        quick_sort(nArr, 0, nArr.Length - 1);

        for (int i = 0; i < nArr.Length; i++)
            Console.Write(nArr[i] + "\t");
    }
    private static int ArryDivide(int[] Arry, int left, int right)
    {
        int PivotValue, temp;
        int index_L, index_R;

        index_L = left;// 매개변수로 들어온 인덱스번호 왼쪽 손가락
        index_R = right; //매개변수로 들어온 인덱스번호 오른쪽 손가락

        //Pivot 값은 0번 인덱스의 값을 가짐
        PivotValue = Arry[left];

        while (index_L < index_R) //모든 과정이 끝났는지 확인하는 조건문
        {
            //Pivot 값 보다 작은경우 index_L 증가(이동)
            while ((index_L <= right) && (Arry[index_L] < PivotValue))
                index_L++;

            //Pivot 값 보다 큰경우 index_R 감소(이동)
            while ((index_R >= left) && (Arry[index_R] > PivotValue))
                index_R--;

            //index_L 과 index_R 이 교차되지 않음
            if (index_L < index_R)
            {
                temp = Arry[index_L];
                Arry[index_L] = Arry[index_R];
                Arry[index_R] = temp;

                //같은 값이 존재 할 경우 
                if (Arry[index_L] == Arry[index_R])
                    index_R--;
            }
        }

        //index_L 과 index_R 이 교차된 경우 반복문을 나와 해당 인덱스값을 리턴
        return index_R;
    }
    private static void quick_sort(int[] arry, int left, int right)
    {
        if (left < right)
        {
            int PivotIndex = ArryDivide(arry, left, right);

            quick_sort(arry, left, PivotIndex - 1);//pivotIndex기준으로 왼쪽 덩어리를 퀵정렬하라
            quick_sort(arry, PivotIndex + 1, right);//pivotIndex기준으로 오른쪽 덩어리를 퀵정렬하라
        }
    }
}

