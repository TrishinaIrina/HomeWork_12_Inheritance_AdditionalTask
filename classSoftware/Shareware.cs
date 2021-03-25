using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classSoftware
{
    public class Shareware: Software
    {
        public Shareware(string title, string manufacturer, string installationDate, int termOfUse):base(title, manufacturer)
        {
            type = "условно-бесплатное";
            this.installationDate = Convert.ToDateTime(installationDate);
            this.termOfUse = termOfUse;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("дата инсталяции: " + installationDate);
            Console.WriteLine("срок бесплатного использования (дней): " + termOfUse);
        }
    }
}
