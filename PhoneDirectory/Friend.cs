using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.PhoneDirectory
{
    public class Friend: PhoneDirectory
    {
        DateTime dateOfBirth;

        public Friend(string name, string adress, string phoneNumber, string dateOfBirth) : base(name, adress, phoneNumber)
        {
            type = "друг";
            this.dateOfBirth = Convert.ToDateTime(dateOfBirth);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("дата рождения: " + dateOfBirth);
        }
    }
}
