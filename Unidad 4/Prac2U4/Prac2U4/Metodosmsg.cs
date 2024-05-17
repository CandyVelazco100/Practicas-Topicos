using System;
using System.Threading;

namespace Prac2U4
{
    class Metodosmsg
    {
        /* Hilo 1 envía un mensaje 10 veces 
         * y luego se manda a dormir durante 1000 milisegundos */
        public void Hilo1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("[" + i + "]" + "EJECUTANDO H1");

                Thread.Sleep(1000);
            }
        }

        /* Hilo 2 envía un mensaje5 veces (va de 2 en 2) 
         * y luego se manda a dormir durante 5000 milisegundos */
        public void Hilo2()
        {
            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine("[" + i + "]" + "EJECUTANDO H2");

                Thread.Sleep(5000);
            }
        }
    }
}