using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0808GitPractice
{
    internal class Person
    {
        public string Name { get; set; }
        public int Telephone { get; set; }

        public Person(string name, int telephone)
        {
            Name = name;
            Telephone = telephone;
            Console.WriteLine($"Name: {name}, Tel: {telephone}");
        }

    }
}
