// See https://aka.ms/new-console-template for more information
using System;
class MainClass
{
    public static void Main()
    {
        int numeroAnterior = 0;
        int numeroActual = 1;
        int novoNumero;
        int fibonacci;

        for (int i = 0; i < 100; i++)
        {
            fibonacci = numeroAnterior + numeroActual;
            Console.WriteLine(fibonacci);
            numeroAnterior = numeroActual;
            numeroActual = fibonacci;
        }
    }
}

