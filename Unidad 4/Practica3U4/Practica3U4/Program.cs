using System;
using System.Diagnostics;
using System.Threading;

namespace Practica3U4
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
            string format = @"ss\.fffffff";

            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();

            Thread thr = Thread.CurrentThread;
            Console.WriteLine("El nombre del hilo es: " + thr.Name);
            Console.WriteLine("HILO #1");
            for (int i = 0; i <= 10; i = i + 2)
            {
                TimeSpan time = timeMeasure.Elapsed;
                Console.WriteLine("HILO 1 EJECUTANDOSE " +i+ " Mostrandose en el milisegundo: "+time.ToString(format));
            }

            timeMeasure.Stop();
            Console.WriteLine($"Tiempo en ejecutarse Hilo 1: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }

        public static void hilo2()
        {
            string format = @"ss\.fffffff";
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();

            Thread thr = Thread.CurrentThread;
            Console.WriteLine("El nombre del hilo es: " + thr.Name);
            Console.WriteLine("HILO #2");
            for (int i = 0; i <= 50; i = i + 5)
            {
                TimeSpan time = timeMeasure.Elapsed;
                Console.WriteLine("HILO 2 EJECUTANDOSE " + i + " Mostrandose en el milisegundo: " + time.ToString(format));
            }

            timeMeasure.Stop();
            Console.WriteLine($"Tiempo en ejecutarse Hilo 2: {timeMeasure.Elapsed.TotalMilliseconds} ms");
        }
    }
}
