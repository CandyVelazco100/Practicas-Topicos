using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac2
{
    public class Empleado
    {
        protected string nombre;
        protected double salario;
        protected string fechaNacimiento;

        public Empleado(string nombre, double salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }

        public Empleado()
        {
            
        }

        public String obtenerDetalles()
        {
            return "Nombre: " + nombre + "\nSalario: " + salario;
        }
    }
}