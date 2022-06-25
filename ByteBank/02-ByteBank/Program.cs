namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = "Gabriela";
            conta.Saldo = 200;

            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Saldo);

        }
    }
}