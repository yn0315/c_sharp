using System;

public class CategoryClass
{
    public void Print(int i) => Console.WriteLine($"카테고리{i}");

}
class ClassArray
{
    static void Main()
    {   //클래스 배열
        CategoryClass[] categories = new CategoryClass[3];

        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}