using System;

namespace _01_ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01!");

            var retorno = Metodo();

            if (retorno == -2)
            {
                Console.WriteLine("Ocorreu um erro!");
            }
            Console.ReadKey();
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        //ao retornar um aviso de erro do testa divisao, precisa saber lidar com erro
        private static int Metodo()
        {
            //return void
            //TestaDivisao(2);
            //Erro DivideByZeroException é um argumento que o método não sabe tratar
            
            //return int
            return TestaDivisao(20);
        }

        //não deve ser responsável pelo controle de erro do método dividir, pra isso precisa avisar o método anterior
         private static int TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            //retorno int
            if (resultado == -2)
            {
                return -2;
            }

            //retorno void
            if (resultado == -1)
            {
                Console.WriteLine("Não é possível fazer divisão por zero");
            }
            else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }

            //retorno int
            return 0;
            //Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        //precisa avisar o método anterior que um problema aconteceu
        //+ Exception: numero = 10, divisor = 20 - resultado double
        private static int Dividir(int numero, int divisor)
        {
            //retorno inteiro - codigo de erro divisão por zero
            if(divisor == 0)
            {
                return -1;
            }

            //mesmo codigo de erro de divisão por zero
            //if (divisor > numero)
            //{
            //    return -1;
            //}

            if (divisor > numero)
            {
                return -2;
            }

            return numero / divisor;
        }
    }
}
