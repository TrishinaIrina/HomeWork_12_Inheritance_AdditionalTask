using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classProduct
{
    public class Product: Wave
    {
        public DateTime productionDate { get; set; }
        public double expirationDate { get; set; }

        public Product() { }
        public Product(string name, int price, string productionDate, double expirationDate): base(name, price)
        {
            this.productionDate = Convert.ToDateTime(productionDate);
            this.expirationDate = expirationDate;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("наименование: " + name);
            Console.WriteLine("цена: " + price);
            Console.WriteLine("дата производства: " + productionDate);
            Console.WriteLine("срок годности (дней): " + expirationDate);
        }

        public override bool IsOverdue()
        {
            return (productionDate.AddDays(expirationDate) < DateTime.Now);
        }
    }

    
}
