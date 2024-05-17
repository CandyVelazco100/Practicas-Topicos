using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac3
{
    public class Circulo : Figura
    {
        private double radio;

        public Circulo(double ra)
        {
            this.radio = ra;
        }

        public override void Dibujar()
        {
            Console.WriteLine("\n");
            Console.WriteLine("      *******      ");
            Console.WriteLine("    ************  ");
            Console.WriteLine("   ************** ");
            Console.WriteLine("   ************** ");
            Console.WriteLine("   **************  ");
            Console.WriteLine("    ***********  ");
            Console.WriteLine("      *******      ");
            Console.WriteLine("\n");
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }
    }
}