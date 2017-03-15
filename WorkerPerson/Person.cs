using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerPerson
{
    public class Person
    {
        public int age;
        public string name;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name{
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void AgeCounter()
        {
            Console.WriteLine(name + " are " + age + " years old");
        }
    }
}