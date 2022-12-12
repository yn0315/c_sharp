using System.Runtime.CompilerServices;
using static System.Console;

namespace PropertyValidation
{
    class Car
    {
        public string Name { get; set; }
        public Car(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentNullException();

            this.Name = name;
        }
       


    }

    class PropertyValidation
    {
        static void Main()
        {

            Car car = new Car("자동차");
            WriteLine(car.Name);
                
        }
    }

}

