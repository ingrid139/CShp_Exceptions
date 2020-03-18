
using System;

//StartCode
public class Inicio
{
    private static void Metodo()
    {
        TestaDivisao(2);
    }

    private static void TestaDivisao(int divisor)
    {
        int resultado = Dividir(10, divisor);

        Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
    }

    private static int Dividir(int numero, int divisor)
    {
        return numero / divisor;
    }
}
