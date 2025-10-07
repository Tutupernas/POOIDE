using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Ex2
    {
        int l1;
        int a;

        public Ex2()
        {
            this.l1 = 0;
            this.a = 0;
        }



        public void setLado(int l1)
        {
            this.l1 = l1;
        }




        public int getLado()
        {
            return this.l1;
        }



        public int getArea()
        {
            return this.a;
        }

        public void calcularArea()
        {
            this.a = this.l1 * this.l1;
        }
    }
}
