using System;

namespace Laboratorio_9_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int cantidad = 10;
            int minimo = 1;
            int maximo = 20;

            int[] numerosUnicos = new int[cantidad];
            int i = 0;

            while (i < cantidad)
            {
                int num = Aleatorio.generar(minimo, maximo);

                bool repetido = false;

                for (int j = 0; j < i; j++)
                {
                    if (numerosUnicos[j] == num)
                    {
                        repetido = true;
                        break;
                    }
                }

                if (!repetido)
                {
                    numerosUnicos[i] = num;
                    i++;
                }
            }
            Console.WriteLine("Arreglo de números únicos:");
            for (int j = 0; j < numerosUnicos.Length; j++)
            {
                Console.Write(numerosUnicos[j] + " ");
            }
        }
    }
}
