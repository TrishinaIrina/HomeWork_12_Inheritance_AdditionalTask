using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classPersona
{
    public class Teacher: Persona
    {
        public string post { get; set; }
        public int experience { get; set; }
        public Teacher(string surname, int year, int month, int day, string faculty, 
            string post, int experience) : base(surname, year, month, day, faculty)
        {
            this.post = post;
            this.experience = experience;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("должность: " + post);
            Console.WriteLine("опыт работы: " + experience);
        }
    }
}
