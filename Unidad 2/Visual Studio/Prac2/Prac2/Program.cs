namespace Prac2 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba nombre del empleado: ");
            String nomEmp = Console.ReadLine();
            Console.WriteLine("Escriba salario del empleado: ");
            string salEmp = Console.ReadLine();
            double salarioEmp = double.Parse(salEmp);

            Console.WriteLine("Escriba nombre del empleado: ");
            String nomMan = Console.ReadLine();
            Console.WriteLine("Escriba salario del empleado: ");
            string salMan = Console.ReadLine();
            double salarioMan = double.Parse(salMan);
    
            Empleado em = new Empleado(nomEmp, salarioMan);
            Manager man = new Manager(nomMan, salarioMan);

            Console.WriteLine("Los datos son: \n" + em.obtenerDetalles() + "\n" + man.obtenerDetalles());
            Console.ReadKey();
        }
    }
}