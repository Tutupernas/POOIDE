using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex10
    {
        double peso;
        double altura;
        double imc;

        public Ex10()
        {
            this.peso = 0;
            this.altura = 0;
            this.imc = 0;
        }



        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public double getPeso()
        {
            return this.peso;
        }



        public void setAltura(double altura)
        {
            this.altura = altura /100;
            
        }




        public double geAltura()
        {
            return this.altura;
        }



        public double getIMC()
        {
            return this.imc;
        }

        public void calcularIMC()
        {
            
            this.imc = this.peso / Math.Pow(this.altura, 2);           

            
        }
    }
}
