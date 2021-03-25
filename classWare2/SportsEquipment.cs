using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classWare2
{
    public class SportsEquipment: Ware2
    {
        public SportsEquipment(string name, double price, string producer, int age):base(name, price, producer, age)
        {
            type = "спортинвентарь";
        }
    }
}
