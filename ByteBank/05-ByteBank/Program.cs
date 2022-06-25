namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           //Cliente gabriela = new Cliente();

           // gabriela.Nome = "Gabriela";
           // gabriela.Cpf = "434.562.878-20";
           // gabriela.Profissão = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();

            //conta.Titular = gabriela;
            conta.Titular = new Cliente();
            conta.Titular.Nome = "Gabriela Costa";
            conta.Titular.Cpf = "434.562.878-20";
            conta.Titular.Profissão = "Desenvolvedora C#";

            conta.Saldo = 500;
            conta.Agencia = 563;
            conta.Numero = 5634527;

            conta.Titular.Nome = "Gabriela Costa";

            //Console.WriteLine(gabriela.Nome);
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.Cpf);
            Console.WriteLine(conta.Titular.Profissão);
        }
    }
}