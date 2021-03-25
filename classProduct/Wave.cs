using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classProduct
{/*Задание 4
1.	Создать абстрактный класс Товар с методами, позволяющим вывести на экран информацию о товаре, 
а также определить, соответствует ли она сроку годности на текущую дату.
2.	Создать производные классы: 
    Продукт (название, цена, дата производства, срок годности), 
    Партия (название, цена, количество шт, дата производства, срок годности), 
    Комплект (названия, цена, перечень продуктов) 
    со своими методами вывода информации на экран, и определения соответствия сроку годности.
3.	Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, 
    а также организовать поиск просроченного товара (на момент текущей даты).
*/
    public abstract class Wave
    {
        public string name { get; set; }
        public int price { get; set; }
        public Wave(){}

        public Wave(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("наименование: " + name);
            Console.WriteLine("цена: " + price);
            Console.WriteLine();
        }
        public abstract bool IsOverdue();
    }
}

