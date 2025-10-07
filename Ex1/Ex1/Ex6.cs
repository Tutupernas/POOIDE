using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex6
    {
        double cotDolar;
        double Reais;
        double dolar;




        public Ex6()
        {
            this.cotDolar = 0;
            this.Reais = 0;
            this.dolar = 0;

        }

        public void setDolar(double dolar)
        {


            this.dolar = dolar;

        }

        public double getDolar()
        {

            return this.dolar;

        }

        public void setCotacao(double cotDolar)
        {


            this.cotDolar = cotDolar;

        }

        public double setCotacao()
        {

            return this.cotDolar;

        }


        public double getReais()
        {

            return this.Reais;

        }

        public void calculaDolar()
        {

            this.Reais = this.cotDolar * this.dolar;
        }
    }
}
