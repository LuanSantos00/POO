namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.Titular = "Gabriela";
            contaDaGabriela.Agencia = 863;
            contaDaGabriela.Numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.Titular = "Gabriela";
            contaDaGabrielaCosta.Agencia = 863;
            contaDaGabrielaCosta.Numero = 863452;


            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));


        }
    }
}