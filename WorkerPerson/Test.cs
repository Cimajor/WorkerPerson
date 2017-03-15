using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerPerson
{
    class Test
    {
        
        static void Main(String[] args)
        {
            int arrayLength = 3;
            Worker[] factory = new Worker[arrayLength];

            Random rnd = new Random();

            for (int i = 0; i < arrayLength; i++)   //creating array of Workers
            {
                Console.WriteLine("Enter name");
                String name;
                name = Console.ReadLine();
                Console.WriteLine("Enter workplace");
                String workplace;
                workplace = Console.ReadLine();
                int age = rnd.Next(0, 50);
                int salary = rnd.Next(100, 400);
                factory[i] = new Worker(name, age, workplace, salary);
            }

            Array.Sort(factory);

            for (int counter = 0; counter < arrayLength; counter++)   //Sllary Increase and Output the resul
            {
                if (factory[counter].age > 0)
                {
                    if (factory[counter].Salary > 200)
                    {
                        factory[counter].SalaryIncrease();
                    }
                    factory[counter].OutPut();
                }
            }
            Console.ReadLine();
        }
    }
}
