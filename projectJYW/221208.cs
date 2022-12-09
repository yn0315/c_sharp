using System;
using System.Collections;

class StackNote
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push("첫번째");
        stack.Push("두번째");
        stack.Push("세번째");

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        try
        {
            Console.WriteLine(stack.Pop());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"예외내용: {ex.Message}");
        }


    }
}