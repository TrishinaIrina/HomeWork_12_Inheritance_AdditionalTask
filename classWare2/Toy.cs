using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classWare2
{
    public class Toy:Ware2
    {
        public string material { get; set; }
        public Toy(string name, double price, string producer, int age, string material):
            base(name, price, producer, age)
        {
            type = "игрушка";
            this.material = material;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("материал: " + material);
        }
    }
}
