using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex9
    {
        int base1;
        int altura;
        int area;
        bool maior;

        public Ex9()
        {
            this.base1 = 0;
            this.altura = 0;
            this.maior = false;
        }



        public void setBase(int base1)
        {
            this.base1 = base1;
        }

        public int getBase()
        {
            return this.base1;
        }

        public void setAltura(int altura)
        {
            this.altura = altura;
        }

        public int getAltura()
        {
            return this.altura;
        }



        public int getArea()
        {
            return this.area;
        }

        public void calcularArea()
        {
            this.area = this.base1 * this.altura;
        }

        public bool verificaMaior()
        {

            if (this.area <= 100)
            {
                return this.maior = false;

            }
            else
            {

                return this.maior = true;
            }

        }
    }
}
