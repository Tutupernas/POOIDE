using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex11
    {
        double ladoA;
        double ladoB;
        double ladoC;


        public Ex11()
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

        public string classificaTriangulo()
        {
            if (!ehTriangulo())
            {
                return "Não é triângulo";
            }

            if (this.ladoA == this.ladoB && this.ladoB == this.ladoC)
            {
                return "Equilátero";
            }
            else if (this.ladoA == this.ladoB || this.ladoA == this.ladoC || this.ladoB == this.ladoC)
            {
                return "Isóceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }
}
