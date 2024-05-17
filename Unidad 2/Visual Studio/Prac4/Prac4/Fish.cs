using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac4
{
    public class Fish : Animal, Pet
    {
        private string name;

        public Fish() : base(0)
        {
            

        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void play()
        {
            Console.WriteLine("El pez juega :) ");
        }

        public void walk()
        {
            base.walk();
        }

        public override void eat()
        {
            Console.WriteLine("Los peces comen comida");
        }
    }
}