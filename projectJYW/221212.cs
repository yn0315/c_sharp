using System;

public class ClassOne
{
    public static void Hi()
    {
        Console.WriteLine("안녕하세요");
    }

    
}
public class ClassTwo
{
    public static void Hi()
    {
        Console.WriteLine("반갑");
    }
    public void Hello()
    {
        Console.WriteLine("또 만나");
    }
}

class ClassDemo
{
    static void Main()
    {
        ClassOne.Hi();
        ClassTwo.Hi();

        ClassTwo ct = new ClassTwo();
        ct.Hello();
    }

    //오버라이딩 : 재정의
    // => 부모로부터 상속받은 자식클래스에서 부모클래스 내에 메서드를 다시 정의 하여 오버라이딩
    //오버로딩 : 같은 이름 메서드 여러개
    // => 생성자 오버로당
    //  1. 매개변수 없는 생성자
    //  2. 매개변수 있는 생성자
    //  3. public or static클래스 주체 or 인스턴스 주체
    //  같은 이름의 생성자가 여러개 있는 것
}