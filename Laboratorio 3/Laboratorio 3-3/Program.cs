using System;

namespace Laboratorio_3_3
{
    class Rectangulo
    {
        public double CalculoPerimetro(double largo, double ancho)
        {
            return 2 * (largo + ancho);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo();

            Console.Write("Ingrese el largo del rectángulo: ");
            double largo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine());

            double perimetro = r.CalculoPerimetro(largo, ancho);

            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
