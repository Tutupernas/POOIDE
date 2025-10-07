using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex3
    {
        double diag;
        double a;

        public Ex3()
        {
            this.diag = 0;
            this.a = 0;

        }

        public void setDiag(double diag)
        {


            this.diag = diag;

        }

        public double getDiag()
        {

            return this.diag;

        }

        public double getArea()
        {

            return this.a;

        }

        public void calculaArea()
        {

            this.a = Math.Pow(this.diag, 2) / 2;


        }
    }
}
