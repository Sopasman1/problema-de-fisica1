using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_de_fisica1
{
    internal class densidad
    {
        public double kilos;
        public double metros3;

        public double Kilos { get => kilos; set => kilos = value; }
        public double Metros3 { get => metros3; set => metros3 = value; }

        public void resultado(double kilos,double metros3)
        {
            this.kilos = kilos;
            this.metros3 = metros3;
        }
    }
}
