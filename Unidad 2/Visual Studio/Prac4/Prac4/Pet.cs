using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac4
{
    public interface Pet
    {
        void setName(string n);
        string getName();
        void play();
    }
}