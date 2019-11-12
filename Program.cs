using System;
using System.Collections.Generic;

namespace HelloDevelopers
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var name = "Ben";

            int x = 2;

            int y = x * 7;

            var person1 = new Person();

            person1.Name = "Ben";
            person1.Age = 28;
            person1.IsDeveloper = true;

            var person2 = new Person(999999) 
            { 
                Name = "Matt",
                Age = 10,
                IsDeveloper = false
            };

            var person3 = new Person()
            {
                Name = "Haseeb",
                Age = 27,
                IsDeveloper = true
            };

            //var person4 = new Person()
            //{
            //    Name = "Rob",
            //    Age = 30,
            //    IsDeveloper = true
            //};

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(new Person()
            {
                Name = "Rob",
                Age = 30,
                IsDeveloper = true
            });

            foreach (var person in people)
            {
                if (!person.IsDeveloper)
                {
                    Console.WriteLine(person.Name + " Is NOT a developer!");
                }
                else 
                { 
                    Console.WriteLine(person.Name + " Is a developer!");
                }

            }


            Console.WriteLine("DONE!");
        }
    }
}
