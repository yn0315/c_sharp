using System;

class MergeAlgorithm
{
    static void Main()
    {
        int[] first = { 1, 3, 5 };
        int[] second = { 2, 4 };
        int M = first.Length;
        int N = second.Length;

        int[] merge = new int[M + N];
        int i = 0;
        int j = 0;
        int k = 0;

        while (i < M && j < N)
        {
            if (first[i] <= second[j])
            {
                merge[k++] = first[i++];
            }
            else
            {
                merge[k++] = second[j++];
            }

        }
        while (i < M)
        {
            merge[k++] = first[i++];
        }
        while (j < N)
        {
            merge[k++] = second[j++];
        }

        foreach (var m in merge)
        {
            Console.Write($"{m}\t");
        }
        Console.WriteLine();
    }
}
