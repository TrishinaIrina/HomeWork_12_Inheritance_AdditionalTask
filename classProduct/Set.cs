using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classProduct
{
    public class Set:Wave
    {
        List<Product> set = new List<Product>();
        int numberOfProducts { set; get; }
        public Set(){}
        public Set(string name, int price, int numberOfProducts) :base(name, price)
        {
            this.numberOfProducts = numberOfProducts;
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.Write("укажите наименование продукта: ");
                string Name = Console.ReadLine();
                Console.Write("цена продукта: ");
                int Price = int.Parse(Console.ReadLine());
                Console.Write("дата изготовления: ");
                string productionDate = Console.ReadLine();
                Console.Write("срок годности (дней): ");
                double expirationDate = int.Parse(Console.ReadLine());
                set.Add(new Product(Name, Price, productionDate, expirationDate));
                Console.WriteLine();
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Перечень продуктов: ");
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine(set[i].name);
            }
        }

        public override bool IsOverdue()
        {
            int count = 0;
            for (int i = 0; i < set.Count; i++)
            {
                if (set[i].productionDate.AddDays(set[i].expirationDate) < DateTime.Now)
                {
                    count++;
                    Console.WriteLine("в корзине " + this.name + " просрочен продукт: " + set[i].name);
                }
            }
            if (count > 0) return true;
            else return false;
        }
    }
}

