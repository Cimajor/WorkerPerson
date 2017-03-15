using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerPerson
{
    class Worker : Person, IComparable<Worker>
    {
        public string workplace;
        public int salary;

        public Worker(string name, int age, string workplace, int salary) : base(name, age)
        {
            this.workplace = workplace;
            this.salary = salary;
        }

        public int Compare(object o1, object o2)
        {
        Worker worker1 = (Worker)o1;
        Worker worker2 = (Worker)o2;

        if (worker1.Name.Length < worker2.Name.Length)
            {
                return 1;
            } else if (worker1.Name.Length == worker2.Name.Length)
            {
                return 0;
            } else
            {
                return -1;
            }
        }

        public string Workplace
        {
            get { return workplace; }
            set { workplace = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void OutPut()
        {
            Console.WriteLine(name + " " + age + " " + Workplace + " " + Salary);
        }

        public void SalaryIncrease()
        {
            int newsalary;
            newsalary = Salary + age;
            Console.WriteLine("new salary is " + newsalary);
        }
        public int CompareTo(Worker p)
        {
            if (p != null)
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

}
