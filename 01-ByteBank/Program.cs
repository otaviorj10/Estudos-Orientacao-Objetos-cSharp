using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var ContaDoPaulo = new ContaCorrente();

            ContaDoPaulo.titular = "Paulo";
            ContaDoPaulo.agencia = 863;
            ContaDoPaulo.numero = 863452;
            ContaDoPaulo.saldo = 100;

            Console.WriteLine(ContaDoPaulo.titular);
            Console.WriteLine("Agencia : " + ContaDoPaulo.agencia);
            Console.WriteLine("Número " + ContaDoPaulo.numero);
            Console.WriteLine("Saldo :" + ContaDoPaulo.titular);

            ContaDoPaulo.saldo += 200;

            Console.WriteLine("Saldo " + ContaDoPaulo.saldo);


            Console.ReadLine();




           


        }
    }
}
