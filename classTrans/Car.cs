using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classTrans
{
    public class Car: Trans
    {
        public override int tonnage { get; set; }
        public Car(string brand, string number, int speed, int tonnage):base(brand, number, speed)
        {
            type = "легковая";
            this.tonnage = tonnage;
            Console.WriteLine();
        }
    }
}
