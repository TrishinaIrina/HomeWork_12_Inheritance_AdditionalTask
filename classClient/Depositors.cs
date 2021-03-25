using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classClient
{
    public class Depositors: Client
    {
        public double rate { get; set; }
        public Depositors(string name, string openingDate, double amount, double rate):
            base(name, openingDate, amount)
        {
            this.rate = rate;         
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("дата вклада: " + openingDate);
            Console.WriteLine("размер вклада: " + amount);
            Console.WriteLine("процентная ставка: " + rate);
        }
    }
}

