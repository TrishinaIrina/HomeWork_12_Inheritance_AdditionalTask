using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classClient
{
/*Задание 6
1.	Создать абстрактный класс Клиент с методами, позволяющими вывести на экран информацию о клиентах банка, 
 а также определить соответствие клиента критерию поиска.
2.	Создать производные классы: 
Вкладчик (фамилия, дата открытия вклада, размер вклада, процент по вкладу), 
Кредитор (фамилия, дата выдачи кредита, размер кредита, процент по кредиту, остаток долга), 
Организация (название, дата открытия счета, номер счета, сумма на счету) 
со своими методами вывода информации на экран, и определения соответствия дате 
(открытия вклада, выдаче кредита, открытия счета).
3.	Создать базу (массив) из n клиентов, вывести полную информацию из базы на экран, 
а также организовать поиск клиентов, начавших сотрудничать с банком в заданную дату.
*/
    public abstract class Client
    {       
        public string name { get; set; }
        public DateTime openingDate { get; set; }
        public double amount { get; set; }

        public Client(string name, string openingDate, double amount)
        {
            this.name = name;
            this.openingDate = Convert.ToDateTime(openingDate);
            this.amount = amount;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("ФИО: " + name);
        }

    }
}
