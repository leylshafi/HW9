using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.ManagerNamespace
{
    using Homework9;
    internal class Manager : Human, IOrganizer,ICalculate
    {
        public string Position { get; set; }
        public Manager(string name, string surname, int age, double salary,string position) : base(name, surname, age, salary)
        {
            Position = position;
        }

        public void CalculateSalaries() => Console.WriteLine("Manager CalculateSalaries");

        public void Organize() => Console.WriteLine("Manager Organize");

        public override string ToString()=>$@"{base.ToString()},
Position: {Position}";
    }
}
