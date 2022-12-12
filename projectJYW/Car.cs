using static System.Console;

namespace DestructorDemo
{
    public class Car
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }
        public Car()
        {
            _name = "승용차";
        }
        public Car(string name)
        {
            _name = name;
        }
        ~Car()
        {
            WriteLine("{0} 폐차..", _name);
        }

    }

    class DestructorDemo
    {
        static void Main()
        {
            Car car1 = new Car();
            WriteLine(car1.GetName());
            Car car2 = new Car("캠핑카");
            WriteLine(car2.GetName());
        }
    }
}