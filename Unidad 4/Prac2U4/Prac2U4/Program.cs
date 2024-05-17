using System;
using System.Threading;

namespace Prac2U4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Si no utilizaramos los join, la ejecucion de ambos hilos se intercalaria 
             * hasta que ambos terminen */

            /* Si utilizamos los join, primero se realiza la ejecucion de un hilo y cuando termina
             * se realiza la ejecucion del otro*/
            Metodosmsg ms = new Metodosmsg();

            Thread th1 = new Thread(ms.Hilo1);
            Thread th2 = new Thread(ms.Hilo2);

            th1.Start();

            /* Join suspende la ejecucion de un hilo hasta que otro se ejecute*/

            //th1.Join();

            th2.Start();

            //th2.Join();

            Console.ReadKey();
        }
    }
}
