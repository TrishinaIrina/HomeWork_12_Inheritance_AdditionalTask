using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classTrans
{
    public abstract class Trans
    {
        /*Задание 2
1.	Создать абстрактный класс Trans с методами позволяющим вывести на экран 
информацию о транспортном средстве,а также определить грузоподъемность транспортного средства.
2.	Создать производные классы: 
a)  Легковая_машина (марка, номер, скорость, грузоподъемность), 
б)  Мотоцикл (марка, номер, скорость, грузоподъемность, наличие коляски, 
при этом если коляска отсутствует, то грузоподъемность равна 0), 
в)  Грузовик (марка, номер, скорость, грузоподъемность, наличие прицепа, 
при этом если есть прицеп, то грузоподъемность увеличивается в два раза) 
со своими методами вывода информации на экран, и определения грузоподъемности.
3.	Создать базу (массив) из n машин, вывести полную информацию из базы на экран, 
а также организовать поиск машин, удовлетворяющих требованиям грузоподъемности.
*/
        public string type { get; set; }
        public string brand { get; set; }
        public string number { get; set; }
        public int speed { get; set; }
        public abstract int tonnage { get; set; }

        public Trans(string brand, string number, int speed)
        {
            this.brand = brand;
            this.number = number;
            this.speed = speed;
        }

     
        public virtual void ShowInfo()
        {
            Console.WriteLine("тип: " + type);
            Console.WriteLine("марка: " + brand);
            Console.WriteLine("номер: " + number);
            Console.WriteLine("скорость: " + speed + " км/час");
            Console.WriteLine("грузоподъемность: " + tonnage + " кг");
        }
    }
}
