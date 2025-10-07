using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex5
    {
        double milhas;
        double milhasMaritimas;
        double quilometros;

        public Ex5()
        {
            this.milhas = 0;
            this.milhasMaritimas = 1852;
            this.quilometros = 0;

        }

        public void setMilhas(double milhas)
        {


            this.milhas = milhas;

        }

        public double getMilha()
        {

            return this.milhas;

        }


        public double getQuilometros()
        {

            return this.quilometros;

        }

        public void calculaQuilometros()
        {

            this.quilometros = (this.milhas * this.milhasMaritimas) / 1000;
        }
    }
}
