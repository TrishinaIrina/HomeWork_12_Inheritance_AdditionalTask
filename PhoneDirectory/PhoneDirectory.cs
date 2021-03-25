using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.PhoneDirectory
{
/*1.	Создать абстрактный класс Телефонный_справочник с методами, 
позволяющими вывести на экран информацию о записях в телефонном справочнике, 
а также определить соответствие записи критерию поиска.
2.	Создать производные классы: 
Персона (фамилия, адрес, номер телефона), 
Организация (название, адрес, телефон, факс, контактное лицо), 
Друг (фамилия, адрес, номер телефона, дата рождения) 
со своими методами вывода информации на экран, и определения соответствия искомому типу.
3.	Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, 
а также организовать поиск в базе по фамилии.
*/
    public abstract class PhoneDirectory
    {
        public string type { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string phoneNumber { get; set; }

        public PhoneDirectory(string name, string adress, string phoneNumber)
        {
            this.name = name;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("тип контакта: " + type);
            Console.WriteLine("ФИО: " + name);
            Console.WriteLine("адрес: " + adress);
            Console.WriteLine("номер телефона: " + phoneNumber);        
        }

        public virtual void Search(string parametr)
        {
            if (name.Contains(parametr) || adress.Contains(parametr) || phoneNumber.Contains(parametr))
            {
                ShowInfo();
            }
        }


    }
}
