using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classTrans
{
    public class Truck:Trans
    {
        private int trailer_;
        public int trailer
        {
            get { return trailer_; }
            set
            {
                if (value == 0 || value == 1)
                {
                    trailer_ = value;
                }
                else throw new Exception("для определения наличия или отсутствия коляски доступен ввод значений только 1 или 0");
            }
        }
        private int tonnage_;
        public override int tonnage
        {
            get { return tonnage_; }
            set
            {
                if (trailer == 0) tonnage_ = value;
                else tonnage_ = value * 2;
            }
        }

        public Truck(string brand, string number, int speed, int trailer, int tonnage) : base(brand, number, speed)
        {
            type = "грузовик";
            this.trailer = trailer;
            this.tonnage = tonnage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("наличие прицепа: " + trailer);
            Console.WriteLine();
        }
    }
}

