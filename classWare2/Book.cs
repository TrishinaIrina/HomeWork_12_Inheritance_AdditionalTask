using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classWare2
{
    public class Book: Ware2
    {
        public string author { get; set; }
        public Book(string name, double price, string producer, int age, string author) :
            base(name, price, producer, age)
        {
            type = "книга";
            this.author = author;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("тип: " + type);
            Console.WriteLine("автор: " + author);
            Console.WriteLine("название: " + name);
            Console.WriteLine("цена: " + price);
            Console.WriteLine("издательство: " + producer);
            Console.WriteLine("возраст: " + age);

        }
    }
}
