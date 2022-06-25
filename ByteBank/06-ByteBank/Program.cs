namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Luan";
            cliente.Cpf = "434.564.879-20";
            cliente.Profissão = "Desenvolvedor";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Saldo);
        }
    }
}