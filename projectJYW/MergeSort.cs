
using System.Diagnostics;

public class MergeSort
{
    static void merge_sort(int[] a) //배열 집어넣어서 병합정렬함수 불러오는 함수
    {
        merge_sort(a, 0, a.Length - 1);
    }
    static void merge_sort(int[] a, int left, int right)
    {
        if (left >= right) return; //왼쪽 값이 더 크면 리턴
        int middle = (left + right - 1) / 2;//중간값 찾기
        merge_sort(a, left, middle);
        merge_sort(a, middle + 1, right);
        int n1 = middle + 1 - left; //왼쪽만 떼어내어 n1에 길이값을 넣는다.
        int n2 = right - middle; //오른쪽만 떼어내어 n2에 길이값을 넣는다.
        int[] L = new int[n1];//왼쪽 배열 생성
        int[] R = new int[n2];//오른쪽 배열 생성

        for (int i = 0; i < n1; i++)
            L[i] = a[left + i];//L배열에 L배열길이만큼 돌리면서 a배열의 왼쪽 값들을 넣는다.

        for(int i = 0; i < n2; i++)
            R[i] = a[middle + 1 + i];//R배열에 R배열 길이만큼 돌리면서 a배열의 오른쪽 값들을 넣는다.


        int k = 0;
        int l = 0;
        int m = left;
        while (k < n1 && l < n2)
        {
            if (L[k] <= R[l])//L배열과 R배열의 동등한 자리를 비교하며, L배열의 크기가 작을 시 
            {
                a[m] = L[k]; //a배열에 L[k]값을 넣는다.(왼쪽값을 넣는다.)
                k++; //다음을 비교해야 하므로 k를 올려준다.
                m++; //다음칸에 넣어야 하므로 m을 올려준다.
            }
            else
            {
                //L배열과 R배열의 동등한 자리를 비교하며, L배열의 크기가 작지 않을 시
                a[m] = R[l]; //a[m]칸에 R[ㅣ]값을 넣는다.(오른쪽 값을 넣는다.)
                l++; //다음을 비교해야 하므로 l을 올려준다.
                m++; //다음칸에 넣어야 하므로 m을 올려준다.
            }
        }
        while (k < n1) // L배열의 길이만큼 반복문을 돌리면서
        {
            a[m] = L[k]; // a[m]자리에 l[k]를 넣어준다.
            k++; //k를 올리며 다음 데이터로 넘어간다.
            m++; //m을 올리면서 다음 자리로 넘어간다.
        }
        while (l < n2) //R배열의 길이만큼 반복문을 돌리면서
        {
            a[m] = R[l]; //a[m]자리에 R[l]을 넣어준다.
            l++; //l을 올리며 다음데이터로 넘어간다.
            m++; //m을 올리면서 다음 자리로 넘어간다.
        }
        

    }

    static void Main()
    {
        Console.WriteLine("배열 길이 입력");
        int count = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[count];
        Console.WriteLine("배열 값 입력");
        Random r = new Random();
        int num = 0;
        for (int i = 0; i < count; i++)
        {
            num = r.Next(100000);
            arr[i] = num;
        }
        //int[] arr = { 9, 1, 22, 4, 0, -1, 1, 22, 100, 10 };
        Stopwatch st = new Stopwatch();
        st.Start();
        merge_sort(arr);
        st.Stop();
        Console.Write(String.Join(",", arr));
        System.Console.WriteLine("time : " +
                           st.ElapsedMilliseconds + "ms");
    }




}

