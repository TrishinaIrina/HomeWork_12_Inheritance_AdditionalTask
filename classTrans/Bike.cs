using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_Inheritance_AdditionalTask.classTrans
{
    public class Bike:Trans
    {
        private int sidecar_;
        public int sidecar
        {
            get { return sidecar_; }
            set
            {
                if (value == 0 || value == 1)
                {
                    sidecar_ = value;
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
                if (sidecar == 0) tonnage_ = 0;
                else tonnage_ = value;
            }
        }

        public Bike(string brand, string number, int speed, int sidecar, int tonnage) : base(brand, number, speed)
        {
            type = "мотоцикл";
            this.sidecar = sidecar;
            this.tonnage = tonnage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo(); 
            Console.WriteLine("наличие коляски: " + sidecar);
            Console.WriteLine();
        }
    }
}
