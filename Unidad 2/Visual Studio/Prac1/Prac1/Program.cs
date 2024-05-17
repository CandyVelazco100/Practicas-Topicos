namespace Prac1 // Note: actual namespace depends on the project name.
{
    public class TestAccount
    {
        public static void Main(string[] args)
        {
            Account a = new Account(50.0);
            Console.Write("Balance inicial: " + a.getBalance());
            Console.ReadKey();

            a.deposit(100.00);
            Console.Write("\nBalance con deposito de 100: " + a.getBalance());
            Console.ReadKey();

            a.withdraw(147.00);
            Console.Write("\nBalance con retiro de 147: " + a.getBalance());
            Console.ReadKey();
        }
    }
}
