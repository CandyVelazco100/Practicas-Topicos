using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac3
{
    public class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado(double l)
        {
            this.lado = l;
        }

        public override void Dibujar()
        {
            Console.WriteLine("\n");
            Console.WriteLine("    * * * *");
            Console.WriteLine("    * * * *");
            Console.WriteLine("    * * * *");
            Console.WriteLine("    * * * *");
            Console.WriteLine("\n");
        }

        public override double Area()
        {
            return Math.Pow(this.lado, 2);
        }
    }
}