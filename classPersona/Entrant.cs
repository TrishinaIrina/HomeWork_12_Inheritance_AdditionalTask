using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classPersona
{
    public class Entrant: Persona
    {
        public Entrant(string surname, int year, int month, int day, string faculty) 
            :base(surname, year, month, day, faculty)
        {
            status = "абитуриент";
        }
    }
}
