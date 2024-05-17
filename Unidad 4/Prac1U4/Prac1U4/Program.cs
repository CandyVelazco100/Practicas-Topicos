using System;
using System.Threading;

namespace Prac1U4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thread nt = new Thread(new ThreadStart(Methilos)); /
            Thread nt = new System.Threading.Thread(Methilos);
            nt.Start();

            for (int i = 1; i <= 10; i++)
                Console.Write(i + "\t");
            Console.Write("\n");
            Console.Write("\n");
            Console.Read();
        }

        static void Methilos()
        {
            for(int i=5; i<=50; i=i+5)
            {
                Console.Write(i + "\t");
            }
        }
    }
}
