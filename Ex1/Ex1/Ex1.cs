using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex1
    {
        int baze;
        int alt;
        int area;

        public Ex1()
        {
            this.baze = 0;
            this.alt = 0;
            this.area = 0;
        }



        public void setBase(int baze)
        {
            this.baze = baze;
        }




        public int getBase()
        {
            return this.baze;
        }

        public void setAltura(int alt)
        {
            this.alt = alt;
        }




        public int getAltura()
        {
            return this.baze;
        }



        public int getArea()
        {
            return this.area;
        }

        public void calcularArea()
        {
            this.area = this.baze * this.alt;
        }
    }
}
