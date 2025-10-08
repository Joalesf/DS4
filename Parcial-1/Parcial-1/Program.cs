using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Matriz A :");
        int a = int.Parse(Console.ReadLine());

        int b;
        do
        {
            Console.WriteLine("Matriz B :");
            b = int.Parse(Console.ReadLine());
        } while (b % 2 == 0);

        int[,] matriz = new int[a, b];
        Random numero = new Random();

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (j % 2 != 0) // columnas impares
                {
                    int valor;
                    do
                    {
                        valor = numero.Next(101, 200); // entre 101 y 199
                    } while (valor % 2 == 0); // asegurar que sea impar
                    matriz[i, j] = valor;
                }
                else
                {
                    matriz[i, j] = 0; // columnas pares quedan en 0
                }
            }
        }

        Console.WriteLine("\nImpresión de la matriz:");

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write(matriz[i, j] + (j + 1 == b ? "\n" : " - "));
            }
        }

        Console.WriteLine($"Muliplicacion de  aleatorios de la segunda columna: {matriz[0, 1] * matriz[a - 1, 1]}");

        Console.ReadKey(true);
    }
}
