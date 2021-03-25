using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classSoftware
{
    public class Free: Software
    {
        public Free(string title, string manufacturer):base(title, manufacturer)
        {
            type = "бесплатное";
            installationDate = DateTime.Now;
            termOfUse = 100;
        }
    }
}
