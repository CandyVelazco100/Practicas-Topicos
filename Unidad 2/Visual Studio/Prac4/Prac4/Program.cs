namespace Prac4
{
    class Program
    {
        static void Main (String [] args)
        {
            Spider witzy = new Spider();

            Console.WriteLine("Escriba un nombre para el gato: ");
            String nameGato = Console.ReadLine();
            Cat garfield = new Cat(nameGato);

            Fish nemo = new Fish();
            Console.WriteLine("Escriba un nombre para el pez: ");
            String namePez = Console.ReadLine ();
            nemo.setName(namePez);

            Console.WriteLine("\nAraña:");
            Console.WriteLine("¿Cuantas patas tiene la araña? ");
            witzy.walk();
            witzy.eat();

            Console.WriteLine("\nGato:");
            Console.WriteLine("Nombre del gato: " + garfield.getName());
            Console.WriteLine("¿Cuantas patas tiene el gato? ");
            garfield.walk();
            garfield.play();
            garfield.eat();

            Console.WriteLine("\nPez:");
            Console.WriteLine("Nombre del pez: " + nemo.getName());
            Console.WriteLine("¿Cuantas patas tiene el pez? ");
            nemo.walk();
            nemo.play();
            nemo.eat();
        }
    }
}
