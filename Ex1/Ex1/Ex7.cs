using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex7
    {
        double valorA;
        double valorB;


        public Ex7()
        {
            this.valorA = 0;
            this.valorB = 0;


        }

        public void setvalorA(double valorA)
        {


            this.valorA = valorA;

        }

        public void setvalorB(double valorB)
        {


            this.valorB = valorB;

        }


        public double verificaMaior()
        {
            if (this.valorA > this.valorB)
            {
                return this.valorA;

            }
            else
            {
                return this.valorB;
            }


        }
    }
}
