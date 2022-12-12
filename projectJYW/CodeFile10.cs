using System.Drawing;
using static System.Console;

namespace PropertyNote
{
    public class Car
    {
        public static string Color;
        private static string _Type;

        public static string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        static Car()
        {
            Color = "Red";
            _Type = "스포츠카";
        }


    }

}
namespace PropertyNote
{
    public class Person
    {
        private int _BirthYear;

        public string Name { get; set; }
        public int BirthYear
        {
            set
            {
                if (value >= 1900)
                {
                    _BirthYear = value;
                }
                else
                {
                    _BirthYear = 0;
                }
            }

        }
        public int Age
        {
            get
            {
                return (DateTime.Now.Year -_BirthYear);
            }
        }
        public Person(string name)
        {
            Name = name;
        }
    }
}
namespace PropertyNote
{
    class PropertyNote
    {
        static void Main()
        {
            Car.Color = "Black";
            Car.Type = "세단";
            WriteLine($"차종: {Car.Type},색상: {Car.Color}");

            Person person = new Person("박용준");
            person.BirthYear = (DateTime.Now.Year - 21);
            WriteLine($"이름: {person.Name}, 나이: {person.Age}");
        }
    }
}