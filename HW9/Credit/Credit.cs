using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.CreditNamespace
{
    using ClientNamespace;
    internal class Credit
    {
        public readonly Guid Id;

        public Client MyClient { get; set; }

        public double Amount { get; set; }
        public int Percent { get; set; }
        public string Months { get; set; }

        public double Payment { get; set; }


        public Credit(Client myClient, double amount, int percent, string months)
        {
            Id = Guid.NewGuid();
            MyClient = myClient;
            Amount = amount;
            Percent = percent;
            Months = months;
            Payment = CalculatePayment();
        }

        public double CalculatePayment()
        {
            return Amount * Percent / 100;
        }

        public override string ToString() => $@"Id: {Id},
Client: {MyClient},
Amount: {Amount},
Percent: {Percent},
Months: {Months},
Payment: {Payment}";

    }
}
