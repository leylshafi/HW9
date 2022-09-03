using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.OperationNamespace
{
    internal class Operation
    {
        public readonly Guid Id;
        public string ProcessName { get; set; }
        public readonly DateTime DateTime;

        public Operation(string processName)
        {
            Id = Guid.NewGuid();
            ProcessName = processName;
            DateTime = DateTime.Now;
        }

        public override string ToString() => $@"Id: {Id},
Process Name: {ProcessName},
Date Time: {DateTime}";
    }
}
