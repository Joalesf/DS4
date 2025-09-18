using System;

namespace Laboratorio_3_2
{
    class Circulo
    {
        public double CalculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo();

            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = c.CalculoArea(radio);

            Console.WriteLine("El área del círculo es: " + area);

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
