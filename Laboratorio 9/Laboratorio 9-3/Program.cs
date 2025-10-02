internal class Program
{
    private static void Main(string[] args)
    {
        int lado1, lado2, lado3;

        Console.WriteLine("Ingrese el primer lado del triángulo:");
        lado1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo lado del triángulo:");
        lado2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer lado del triángulo:");
        lado3 = Convert.ToInt32(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es EQUILÁTERO.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es ISÓSCELES.");
            }
            else
            {
                Console.WriteLine("El triángulo es ESCALENO.");
            }
        }
        else
        {
            Console.WriteLine("Los lados ingresados NO forman un triángulo válido.");
        }
    }
}
