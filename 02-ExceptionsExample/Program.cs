using System;

namespace _02_ExceptionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02!");
            
            //o erro se propaga pela pilha até algum metodo conseguir tratar, caso contrário o erro estoura
            try
            {
                Metodo();   
            }
            //NullReferenceException é uma classe
            // e: boa prática
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                //Rastro de pilha
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro.");
            }

            Console.ReadKey();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            //tentar
            try
            {
                int resultado = Dividir(10, divisor);

                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

            }
            //pegar
            //DivideByZeroException é uma classe
            // e: boa prática
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                //Rastro de pilha
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Não é possível fazer uma divisão por zero.");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            //referencia de objeto apontando para lugar nenhum
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
    }
}
