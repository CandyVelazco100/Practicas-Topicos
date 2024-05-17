using System;
using System.Diagnostics;
using System.Threading;

namespace Prac3U4
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart nuevohilo1 = new ThreadStart(hilo1);
            Thread h1 = new Thread(new ThreadStart(nuevohilo1));
            ThreadStart nuevohilo2 = new ThreadStart(hilo2);
            Thread h2 = new Thread(nuevohilo2);

            h1.Name = "Hilo 1";
            h2.Name = "Hilo 2";

            h1.Start();
            h1.Join();

            h2.Start();
            h2.Join();

            Console.ReadKey();
        }

        public static void hilo1()
        {

            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();

            Console.WriteLine("HILO #1");
            for(int i=0; i<= 20; i = i+2)
            {
                Console.WriteLine(i);
            }

            Thread thr = Thread.CurrentThread;
            Console.WriteLine("El nombre del hilo es: " + thr.Name);

            timeMeasure.Stop();
            Console.WriteLine($"Tiempo Hilo 1: {timeMeasure.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine($"Tiempo Hilo 1: {timeMeasure.Elapsed.TotalSeconds} s");
        }

        public static void hilo2()
        {
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();

            Console.WriteLine("HILO #2");
            for (int i = 0; i <= 30; i=i+3)
            {
                Console.WriteLine(i);
            }
            
            Thread thr = Thread.CurrentThread;
            Console.WriteLine("El nombre del hilo es: " + thr.Name);

            timeMeasure.Stop();
            Console.WriteLine($"Tiempo Hilo 2: {timeMeasure.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine($"Tiempo Hilo 2: {timeMeasure.Elapsed.TotalSeconds} s");
        }
    }
}
