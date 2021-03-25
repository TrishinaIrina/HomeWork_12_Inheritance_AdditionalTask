using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classPersona
{
    public class Student: Persona
    {
        private int course_;
        public int course
        {
            get { return course_; }
            set 
            {
                if (value < 1 || value > 5)
                {
                    throw new Exception("значение для курса может быть только от 1 до 5");
                }
                else course_ = value;
            }
        }
        public Student(string surname, int year, int month, int day, string faculty, int course)
            :base(surname, year, month, day, faculty)
        {
            status = "студент";
            this.course = course;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("номер курса: " + course);
        }
    }
}
