using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex12
    {
        double ladoA;
        double ladoB;
        double ladoC;


        public Ex12()
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.ladoC = 0;

        }

        public void setLadoA(double ladoA)
        {
            this.ladoA = ladoA;
        }

        public double getLadoA()
        {
            return this.ladoA;
        }

        public void setLadoB(double ladoB)
        {
            this.ladoB = ladoB;

        }

        public double getLadoB()
        {
            return this.ladoB;
        }

        public void setLadoC(double ladoC)
        {
            this.ladoC = ladoC;
        }

        public double getLadoC()
        {
            return this.ladoC;
        }



        public bool ehTriangulo()
        {

            return (this.ladoA + this.ladoB > this.ladoC) && (this.ladoA + this.ladoC > this.ladoB) && (this.ladoB + this.ladoC > this.ladoC);

        }

        public bool EhRetangulo()
        {
            if (!ehTriangulo())

                return false;


            double hipotenusa = Math.Max(this.ladoA, Math.Max(this.ladoB, this.ladoC));
            double cateto1, cateto2;

            if (hipotenusa == this.ladoA)
            {
                cateto1 = this.ladoB;
                cateto2 = this.ladoC;
            }
            else if (hipotenusa == this.ladoB)
            {
                cateto1 = this.ladoA;
                cateto2 = this.ladoC;
            }
            else
            {
                cateto1 = this.ladoA;
                cateto2 = this.ladoB;
            }

            // margem de erro do ponto flutuante double

            return Math.Abs(Math.Pow(hipotenusa, 2) - (Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2))) < 0.0001;
        }
    }
}
