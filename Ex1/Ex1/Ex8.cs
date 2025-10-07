using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex8
    {
        double valorA;
        double valorB;
        bool igual;


        public Ex8()
        {
            this.valorA = 0;
            this.valorB = 0;
            this.igual = false;


        }

        public void setvalorA(double valorA)
        {


            this.valorA = valorA;

        }

        public void setvalorB(double valorB)
        {


            this.valorB = valorB;

        }

        public void setIgual(bool igual)
        {


            this.igual = igual;

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

        public bool verificaIgual()
        {
            if (this.valorA == this.valorB)
            {
                return this.igual = true;

            }
            else
            {

                return this.igual;


            }

        }
    }
}
