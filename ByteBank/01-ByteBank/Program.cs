namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDagabriela = new ContaCorrente();

            contaDagabriela.Titular = "Gabriela";
            contaDagabriela.Agencia = 863;
            contaDagabriela.Numero = 863452; 
            contaDagabriela.Saldo = 100;

            Console.WriteLine(contaDagabriela.Titular);
            Console.WriteLine("Agência: " + contaDagabriela.Agencia);
            Console.WriteLine("Número: " + contaDagabriela.Numero);
            Console.WriteLine("Saldo: " + contaDagabriela.Saldo);


            contaDagabriela.Saldo += 200;
            Console.WriteLine("Saldo: " + contaDagabriela.Saldo);

        }
    }
}