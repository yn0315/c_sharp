using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Intrinsics.Arm;
using static System.Console;

namespace NullWithObject
{
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }


    }
    class Address
    {
        public string Street { get; set; } = "알 수 없음";

    }
    class NullWithObject
    {
        static void Main()
        {
            var people = new Person[] { new Person { Name = "RedPlus" }, null  };
            ProcessPeople(people);

            void ProcessPeople(IEnumerable<Person> peopleArray)
            {
                foreach (var person in peopleArray)
                {
                    WriteLine($"{person?.Name ?? "아무개"}는 " + $"{ person?.Address?.Street?? "아무곳"}에 삽니다.");
                }
            }

            var othorPeople = null as Person[];
            WriteLine($"첫번째 사람 : {othorPeople?[0]?.Name??"없음"}");
        }
    }
}