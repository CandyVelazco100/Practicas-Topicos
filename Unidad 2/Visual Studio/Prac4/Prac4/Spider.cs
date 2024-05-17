using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac4
{
    public class Spider : Animal
    {
        public Spider() :  base(8)
        {
           
        }

        public override void eat()
        {
            Console.WriteLine("La arañas comen insectos :)");
        }
    }
}