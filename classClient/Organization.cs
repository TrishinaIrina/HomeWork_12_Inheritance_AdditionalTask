using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classClient
{
    class Organization: Client
    {
        public string accountNumber { get; set; }
        public Organization(string name, string openingDate, double amount, string accountNumber):
            base(name, openingDate, amount)
        {
                this.accountNumber = accountNumber;
        }
        public override void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("название: " + name);
            Console.WriteLine("дата открытия счета: " + openingDate);
            Console.WriteLine("номер счета: " + accountNumber);
            Console.WriteLine("сумма на счету: " + amount);           
        }
    }
}
