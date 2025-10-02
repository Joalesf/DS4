using System;

namespace Laboratorio_9_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int numero = Aleatorio.generar(1, 100);
            Console.WriteLine("Número aleatorio: " + numero);

            int[] numeros = Aleatorio.arreglo(5, 1, 50);
            Console.WriteLine("Arreglo generado: " + string.Join(", ", numeros));
        }
    }
}
