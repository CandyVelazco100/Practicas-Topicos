﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac4
{
    public abstract class Animal
    {
        protected int legs;

        protected Animal(int legs)
        {
            this.legs = legs;
        }

        public void walk()
        {
            Console.WriteLine(this.legs);
        }

        public abstract void eat();
    }
}