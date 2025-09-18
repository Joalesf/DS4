using System;

namespace Laboratorio_3_1
{
    
    class CalculosMatematicos
    {
        public int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            CalculosMatematicos calculos = new CalculosMatematicos();
            int resultado = calculos.Calcular(a, b);

            Console.WriteLine("El resultado de la operación (a+b)*(a-b) es: " + resultado);
        }
    }
}
