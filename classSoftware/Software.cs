using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classSoftware
{
    public abstract class Software
    {
/*Задание 7
1.	Создать абстрактный класс Программное_обеспечение с методами, позволяющими вывести
на экран информацию о программном обеспечении, а также определить соответствие возможности использования (на момент текущей даты).
2.	Создать производные классы: 
Свободное (название, производитель), 
Условно-бесплатное (название, производитель, дата установки, срок бесплатного использования), 
Коммерческое (название, производитель, цена, дата установки, срок использования) 
со своими методами вывода информации на экран, и определения возможности использования на текущую дату.
3.	Создать базу (массив) из n видов программного обеспечения, вывести полную информацию из базы на экран, 
а также организовать поиск программного обеспечения, которое допустимо использовать на текущую дату.
*/
        public string type { get; set; }
        public string title { get; set; }
        public string manufacturer { get; set; }
        public DateTime installationDate { get; set; }
        public int termOfUse { get; set; }

        public Software(string title, string manufacturer)
        {
            this.title = title;
            this.manufacturer = manufacturer;          
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("название программного обеспечения: " + title);
            Console.WriteLine("тип: " + type);
            Console.WriteLine("изготовитель: " + manufacturer);
        }
        public bool AbilityToUse()
        {
            if (DateTime.Now < installationDate.AddDays(termOfUse)) return true;
            else return false;
        }
    }
}
