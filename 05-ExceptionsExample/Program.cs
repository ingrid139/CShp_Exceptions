using System;
using System.IO;

namespace _05_ExceptionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05!");

            try
            {
                CarregarContas();
            }
            catch (IOException)
            {
                Console.WriteLine("Catch no método main!");
            }

            Console.ReadKey();
        }

        private static void CarregarContas()
        {
            //using verifica automaticamente se nossa variavel é nula e não entra no bloco de código
            //a construção using chama o metodo dispose ao finalizar o bloco (fechando o arquivo mesmo quando dá exceção) - try/finally
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
            }
        }
    }
}
