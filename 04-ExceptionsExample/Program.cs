using System;
using System.IO;

namespace _04_ExceptionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("04!");

            CarregarContas();

            Console.ReadKey();
        }

        private static void CarregarContas()
        {
            //LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
            LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("contas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

                //leitor.Fechar();
            }
            //FileNotFoundException herda de IOException
            catch (IOException)
            {
                //leitor.Fechar();
                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }
            //é executado sempre, com ou sem exceção evitando duplicação de código
            finally
            {
                //ao simular erro de arquivo não encontrado a variável leitor não é instanciada
                if (leitor != null)
                {
                    leitor.Fechar();
                }
            }
            
        }
    }
}
