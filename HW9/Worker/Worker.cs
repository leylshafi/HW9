﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.WorkerNamespace
{
    using Homework9;
    using OperationNamespace;
    class Worker : Human
    {
        public string Position { get; set; }
        public readonly DateTime StartTime;
        public readonly DateTime EndTime;
        List<Operation> Operations;
        public Worker(string name, string surname, int age, double salary,string position) : base(name, surname, age, salary)
        {
            Position = position;
            StartTime = DateTime.Now;
            EndTime = DateTime.Now;
            Operations = new List<Operation>();
        }

        public void AddOperation()
        {
            Console.WriteLine("Enter Process Name");
            Operations.Add(new Operation(Console.ReadLine()));
        }

        public override string ToString()=>$@"{base.ToString()},
Position: {Position},
Start time: {StartTime},
End Time: {EndTime}";

        
    }
}
