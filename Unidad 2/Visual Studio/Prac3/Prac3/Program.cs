namespace Prac3
{
    class Program
    {
        static void Main (String [] args)
        {
            Console.WriteLine("Escriba lado del cuadrado: ");
            string lado = Console.ReadLine();
            double l = double.Parse(lado);

            Console.WriteLine("Escriba el radio del circulo: ");
            string radio = Console.ReadLine();
            double ra = double.Parse(radio);

            Cuadrado cuad = new Cuadrado(l);
            Circulo circ = new Circulo(ra);

            Console.WriteLine("      Cuadrado      ");
            Console.WriteLine("Area: \n" + cuad.Area());
            cuad.Dibujar();

            Console.WriteLine("      Circulo      ");
            Console.WriteLine("Area: \n" + circ.Area());
            circ.Dibujar();

            Console.ReadKey();
        }
    }
}
