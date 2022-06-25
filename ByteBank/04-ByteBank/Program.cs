namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBrunno = new ContaCorrente();

            contaDoBrunno.Titular = "Bruno";

            bool resultadoSaque = contaDoBrunno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBrunno.Saldo);
           

            contaDoBrunno.Depositar(500);
            Console.WriteLine(contaDoBrunno.Saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.Titular = "Gabriela";

            Console.WriteLine("Saldo do bruno: " + contaDoBrunno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.Saldo);

            bool resultadoTransferencia = contaDoBrunno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do bruno: " + contaDoBrunno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.Saldo);

            Console.WriteLine(resultadoTransferencia);


        }
    }
}