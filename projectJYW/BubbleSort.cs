using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        int[] Arr = new int[] { 1, 4, 3, 5, 9, 6, 2, 7, 8, 10 };

        int temp;//임시 배열을 선언한다.
        
        for (int i = 0; i < Arr.Length - 1; i++)//회전을 배열의 길이 -1만큼 한다.
        {
            for (int j = 0; j < Arr.Length - 1; j++) //회전을 배열의 길이 -1만큼 하면서
            {
                if (Arr[j] < Arr[j + 1])//앞과 뒤의 크기를 비교 후, 뒤의 값이 크면
                {
                    temp = Arr[j + 1]; //임시배열에 뒤의 값을 저장한다.
                    Arr[j + 1] = Arr[j]; //뒤의 값[j + 1]의 자리에는 앞의 값을 저장하고
                    Arr[j] = temp;// 앞의 자리에 임시배열에 있던 뒤의 값을 저장함으로써 값을 바꾸는 작업을 마무리한다.
                 
                    //i만큼 회전을 하면서 내부 for문에 들어와서는 앞과 뒤의 데이터를 계속적으로 비교해가는 정렬이다.
                    //0,1 -> 1,2 -> 2,3 ...으로 비교하면서 값을 서로 바꿔주는 정렬이다.
                }
            }
        }



        for (int i = 0; i < Arr.Length; i++)
            Console.Write(Arr[i] + "\t");
    }
}