using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask
{
    class Program
    {
        public static void Task2()
        {
            try
            {
                classTrans.Trans car = new classTrans.Car("Toyota", "012TDA05", 220, 1650);
                classTrans.Bike bike = new classTrans.Bike("Java", "12542D", 270, 1, 100);
                classTrans.Truck track = new classTrans.Truck("Mersedes", "25FE2563", 150, 1, 200);
                List<classTrans.Trans> parking = new List<classTrans.Trans>();
                parking.Add(car);
                parking.Add(bike);
                parking.Add(track);
                Console.Write("Введите требуемую грузоподъемность для поиска авто: ");
                int tonnage = int.Parse(Console.ReadLine());
                foreach (var item in parking)
                {
                    if (item.tonnage >= tonnage)
                    {
                        item.ShowInfo();
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Task3()
        {
            try
            {
                classPersona.Persona persona1 = new classPersona.Entrant("Ильясов Т.Р.", 2005, 10, 22, "Архитектрура");
                classPersona.Persona persona2 = new classPersona.Entrant("Попов О.M.", 2004, 5, 2, "Строительство");
                classPersona.Persona persona3 = new classPersona.Student("Трунов Ф.Ю.", 1999, 1, 3, "Строительство", 3);
                classPersona.Persona persona4 = new classPersona.Student("Айтенов Б.О.", 1990, 12, 30, "Электроэнергетика", 5);
                classPersona.Persona persona5 = new classPersona.Teacher("Иванов О.M.", 1979, 9, 2, "Экономика", "декан", 25);
                classPersona.Persona persona6 = new classPersona.Teacher("Кирбаев Е.А.", 1967, 1, 3, "Геодезия", "заведующий кафедрой", 30);

                List<classPersona.Persona> university = new List<classPersona.Persona>();
                university.Add(persona1);
                university.Add(persona2);
                university.Add(persona3);
                university.Add(persona4);
                university.Add(persona5);
                university.Add(persona6);

                foreach (var item in university)
                {
                    item.ShowInfo();
                    item.GetAge();
                    Console.WriteLine();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Task4()
        {
            try
            {
                classProduct.Wave wave1 = new classProduct.Product("молоко", 675, "12.03.2021", 180);
                classProduct.Wave wave2 = new classProduct.Product("кефир", 345, "1.02.2021", 20);
                classProduct.Wave wave3 = new classProduct.Product("йогурт", 165, "2.01.2021", 30);
                classProduct.Wave wave4 = new classProduct.Product("шоколад", 350, "4.01.2021", 365);
                classProduct.Wave wave5 = new classProduct.Batch("печенье", 250, "28.05.2020", 50, 750);
                classProduct.Wave wave6 = new classProduct.Set("продуктовая корзина 1", 2500, 3);
                List<classProduct.Wave> list = new List<classProduct.Wave>();
                list.Add(wave1);
                list.Add(wave2);
                list.Add(wave3);
                list.Add(wave4);
                list.Add(wave5);
                list.Add(wave6);
                Console.WriteLine();
                Console.WriteLine("Полный перечень товаров: ");
                Console.WriteLine("******************************************");
                foreach (var item in list)
                {
                    item.ShowInfo();
                }

                Console.WriteLine();
                Console.WriteLine("C истекшим сроком годности: ");
                Console.WriteLine("******************************************");
                foreach (var item in list)
                {
                    if (item.IsOverdue()) Console.WriteLine(item.name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void Task7()
        {
            List<classWare2.Ware2> list = new List<classWare2.Ware2>();
            list.Add(new classWare2.Toy("монополия", 4500, "ТОО \"Настольные игры\"", 5, "картон"));
            list.Add(new classWare2.Toy("кубики", 1000, "ТОО \"Для самых маленьких\"", 0, "дерево"));
            list.Add(new classWare2.Book("Наука логика", 4500, "\"МосИздат\"", 10, "Гегель Фридрих"));
            list.Add(new classWare2.Book("Чистая архитектура", 3800, "ООО \"Питер\"", 7, "Роберт Мартин"));
            list.Add(new classWare2.SportsEquipment("груша", 7500, "ТОО \"СпортKZ\"", 9));
            list.Add(new classWare2.SportsEquipment("гантели", 2500, "ТОО \"СпортKZ\"", 6));

            foreach (var item in list)
            {
                item.ShowInfo();
                Console.WriteLine();
            }

            classWare2.Ware2.Search(list, "игрушка");
        }
        public static void Task5()
        {
            List<PhoneDirectory.PhoneDirectory> list = new List<PhoneDirectory.PhoneDirectory>();
            list.Add(new PhoneDirectory.Person("Чернышевский", "г. Москва, ул. Длинная, д.18", "8788555455221"));
            list.Add(new PhoneDirectory.Person("Ильясов Таир", "п.Отеген батыр, ул. Титова д.701", "87885525641"));
            list.Add(new PhoneDirectory.Organization("AO \"RBF\"", "ул. Манаса, д.24Б", "3432234", "51515161", "Коругов А.Г."));
            list.Add(new PhoneDirectory.Organization("OOO \"Alfa\"", "ул. Кирова, д.36", "6995234", "789622555155", "Шиятов К.С."));
            list.Add(new PhoneDirectory.Friend("Попов Е.С.", "ул. Закарпатская, д.1", "8755265552221", "6.4.1980"));
            list.Add(new PhoneDirectory.Friend("Ильина Юлия", "ул. Суюнбая, д.104, кв.22", "877365552221", "26.8.1985"));
            foreach (var item in list)
            {
                item.ShowInfo();
            }
            foreach (var item in list)
            {
                item.Search("Таир");
            }
        }
        public static void SearchCliet(List<classClient.Client> list, DateTime date)
        {
            foreach (var item in list)
            {
                if (item.openingDate == date)
                    item.ShowInfo();
            }
        }
        public static void Task6()
        {
            List<classClient.Client> list = new List<classClient.Client>();
            list.Add(new classClient.Depositors("Попов Е.С.", "22.02.2007", 3500000, 11));
            list.Add(new classClient.Debtor("Ильина Юлия", "12.05.2017", 250000, 25, 100000));
            list.Add(new classClient.Organization("OOO \"Alfa\"", "4.12.2020", 36000000, "KZ24734429392"));
            foreach (var item in list)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
            Console.WriteLine("Введите дату для поиска: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            SearchCliet(list, date);

        }
        public static void Task7_1()
        {
            List<classSoftware.Software> list = new List<classSoftware.Software>();
            list.Add(new classSoftware.Free("Visual Studio", "Microsoft"));
            list.Add(new classSoftware.Free("Linux", "Linux"));
            list.Add(new classSoftware.Shareware("Eset NOD 32", "Linux", "21.08.2018", 90));
            list.Add(new classSoftware.Shareware("Microsoft Office", "Microsoft", "2.03.2020", 120));
            list.Add(new classSoftware.Commercial("ABC-4", "АВС Сметные решения", "04.05.2019", 365));
            list.Add(new classSoftware.Commercial("Autodesk 3dsMax", "Yost Group", "07.11.2018", 1095));
            foreach (var item in list)
            {
                item.ShowInfo();
                if (item.AbilityToUse()) Console.WriteLine("программное обеспечение возможно использовать на текущую дату");
                else Console.WriteLine("срок бесплатного (оплаченного) использования истек");
            }          
        }
        static void Main(string[] args)
        {
            //Task2();
            //Task3();
            //Task4();
            //Task7();
            //Task5();
            //Task6();
            Task7_1();
        }


    }
}
