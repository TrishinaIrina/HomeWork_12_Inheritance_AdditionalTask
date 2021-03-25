using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classWare2
{
    /*Задание 7
1.	Создать абстрактный класс Товар с методами, позволяющими вывести на экран информацию о товаре, 
а также определить, соответствует ли она искомому типу.
2.	Создать производные классы: 
Игрушка (название, цена, производитель, материал, возраст, на который рассчитана), 
Книга (название, автор, цена, издательство, возраст, на который рассчитана), 
Спорт-инвентарь (название, цена, производитель, возраст, на который рассчитана), 
со своими методами вывода информации на экран, и определения соответствия искомому типу.
3.	Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, 
а также организовать поиск товаров определенного типа.
*/
    public abstract class Ware2
    {
        public string type { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string producer { get; set; }
        public int age { get; set; }

        public Ware2(string name, double price, string producer, int age)
        {
            this.name = name;
            this.price = price;
            this.producer = producer;
            this.age = age;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("тип: " + type);
            Console.WriteLine("наименование: " + name);
            Console.WriteLine("цена: " + price);
            Console.WriteLine("производитель: " + producer);
            Console.WriteLine("возраст: " + age);
        }
        public static void Search(List <Ware2> list, string type)
        {
            foreach (var item in list)
            {
                if (item.type == type)
                {
                    item.ShowInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
