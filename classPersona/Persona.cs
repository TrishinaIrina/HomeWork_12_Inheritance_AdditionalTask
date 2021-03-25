using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classPersona
{
    /*Задание 3
1.	Создать абстрактный класс Persona с методами, позволяющим вывести на экран информацию о персоне,
а также определить ее возраст (на момент текущей даты).
2.	Создать производные классы: 
Абитуриент (фамилия, дата рождения, факультет), 
Студент (фамилия, дата рождения, факультет, курс), 
Преподавать (фамилия, дата рождения, факультет, должность, стаж), 
со своими методами вывода информации на экран, и определения возраста.
3.	Создать базу (массив) из n персон, вывести полную информацию из базы на экран, 
а также организовать поиск персон, чей возраст попадает в заданный диапазон.
*/
    public abstract class Persona
    {
        public string status { get; set; }
        public string surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string faculty { get; set; }

        public Persona(string surname, int year, int month, int day, string faculty)
        {
            this.surname = surname;
            dateOfBirth = new DateTime(year, month, day);
            this.faculty = faculty;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Статус: " + status);
            Console.WriteLine("ФИО: " + surname);
            Console.WriteLine("Дата рождения: " + dateOfBirth);
            Console.WriteLine("Факультет: " + faculty);
        }

        public void GetAge()
        {
            Console.WriteLine("возраст: " + (int)((DateTime.Now - dateOfBirth).TotalDays / 365)); 
        }
    }
}
