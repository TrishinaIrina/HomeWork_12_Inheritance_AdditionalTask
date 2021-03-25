using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classClient
{
    public class Debtor: Client
    {
        public double rate { get; set; }
        public double ramainingDebt { get; set; }
        public Debtor(string name, string openingDate, double amount, double rate, double ramainingDebt) :
            base(name, openingDate, amount)
        {
            this.rate = rate;
            this.ramainingDebt = ramainingDebt;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("дата оформления кредита: " + openingDate);
            Console.WriteLine("размер кредита: " + amount);
            Console.WriteLine("процентная ставка: " + rate);
            Console.WriteLine("остаток долга: " + ramainingDebt);
        }
    }    
}
