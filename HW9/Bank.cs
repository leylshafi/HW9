using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    using HW9.CEONamespace;
    using WorkerNamespace;
    using ManagerNamespace;
    using ClientNamespace;
    using CreditNamespace;
    internal class Bank
    {
        public string Name { get; }
        public double Budget { get; }
        public double Profit { get; }

        CEO CEO { get; }
        List<Worker> workers = new List<Worker>();
        List<Manager> Managers = new List<Manager>();
        List<Client> Clients = new List<Client>();

        public Bank(string name, double budget, double profit)
        {
            Name = name;
            Budget = budget;
            Profit = profit;
        }

        public Credit ShowClientCredit(string name)
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].Name == name)
                    return Clients[i].Credit;
                else return null;
            }
            return null;
        }

        public void PayCredit(Client client, double money)
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i] == client)
                    Clients[i].Credit.Amount -= money;
            }
        }

        public void ShowAllCredit()
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                Console.WriteLine(Clients[i].Credit);
            }
        }
    }
}
