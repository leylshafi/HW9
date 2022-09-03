using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.CEONamespace
{
    using Homework9;
    class CEO : Human,IControl, IMeet, IDecrease, IOrganizer
    {
        public string Position { get; set; }
        public CEO(string name, string surname, int age, double salary,string position) : base(name, surname, age, salary)
        {
            Position = position;
        }

        public void Control() => Console.WriteLine("CEO Control");

        public void DecreasePersentage() => Console.WriteLine("CEO DecreasePersentage");

        public void MakeMeeting() => Console.WriteLine("CEO MakeMeeting");

        public void Organize() => Console.WriteLine("CEO Organize");

        public override string ToString()=>$@"{base.ToString()},
Position: {Position}";
    }
}
