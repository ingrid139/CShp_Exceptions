using System;

namespace _03_ExceprionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03!");

            try
            {
                Metodo();
            }
            //exceção lançada começa de cima para baixo e testa se o catch consegue tratar a exceção
            //os dois blocos fazem o mesmo, elas herdam de Exception!
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine("Aconteceu um erro.");
            //}
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Não é possível fazer uma divisão por zero.");
            }
            //a CLR aceita DivideByZeroException e NullReferenceException - polimorfismo, toda Exceção deriva de Exception
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro.");
            }
            //bloco catch após classe de Exception nunca será executado, pois pegará todas exceções filhas, nunca será executado
            //catch (DivideByZeroException e)

            Console.ReadKey();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            //referencia de objeto apontando para lugar nenhum
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);

            //try/catch é um controle de fluxo como if/else.No momento que a exceção é lançada a clr muda o controle do fluxo e vai pro bloco catch
            try
            {
                return numero / divisor;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numeros= " + numero + " e divisor= " + divisor);
                //lançando a exceção que esse bloco pega - controle de fluxo 
                throw;
            }

        }
    }
}
