using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.PhoneDirectory
{
    public class Organization: PhoneDirectory
    {
        public string fax { get; set; }
        public string contactPerson { get; set; }
        public Organization(string name, string adress, string phoneNumber, string fax, string contactPerson):
            base(name, adress, phoneNumber)
        {
            type = "организация";
            this.fax = fax;
            this.contactPerson = contactPerson;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("факс: " + fax);
            Console.WriteLine("контактное лицо: " + contactPerson);
        }

        public override void Search(string parametr)
        {
            if (name.Contains(parametr) || adress.Contains(parametr) || phoneNumber.Contains(parametr) 
                || fax.Contains(parametr) || contactPerson.Contains(parametr))
            {
                ShowInfo();
            }
        }
    }
}
