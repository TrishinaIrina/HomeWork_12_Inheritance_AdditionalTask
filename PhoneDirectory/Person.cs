using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.PhoneDirectory
{
    public class Person: PhoneDirectory
    {
        public Person(string name, string adress, string phoneNumber):base(name, adress, phoneNumber)
        {
            type = "персона";
        }
    }
}
