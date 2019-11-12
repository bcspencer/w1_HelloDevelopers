using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDevelopers
{
    public class Person
    {
        private int _money = 10000;

        public Person()
        {
        }

        public Person(int money)
        {
            _money = money;
        }


        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsDeveloper { get; set; }
    }
}
