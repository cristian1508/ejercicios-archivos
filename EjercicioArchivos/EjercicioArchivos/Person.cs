using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArchivos
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; } 
        public string Location { get; set; }

        public Person(string name, int age, string location)
        {
            Name = name;
            Age = age;
            Location = location;
        }


    }
}
