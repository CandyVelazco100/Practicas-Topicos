using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac4
{
    public class Cat : Animal, Pet
    {
        private string name;

        public Cat(string n) : base(4)
        {
            this.name = n;
        }

        public void setName(string n)
        {
            this.name = n;
        }

        public string getName()
        {
            return this.name;
        }

        public void play()
        {
            Console.WriteLine("El gato juega con el estambre");
        }

        public override void eat()
        {
            Console.WriteLine("Los gatos comen");
        }
    }
}