using System;
using System.IO;

namespace _05_ExceptionsExample
{
    //ao utilizar using, obrigatoriamente temos que implementar a interface IDisposable para liberar os recursos após utiliza-los - fechar arquivo
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            //throw new IOException();

            return "Linha do arquivo";
        }

        //public void Fechar()
        //{
        //    Console.WriteLine("Fechando arquivo.");
        //}

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
