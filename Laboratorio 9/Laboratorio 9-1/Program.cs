using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int precio;
        string forma_depago;

        Console.WriteLine("Ingrese el precio del producto:");
        precio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la forma de pago (Efectivo, Tarjeta):");
        forma_depago = Console.ReadLine();

        switch (forma_depago)
        {
            case "Efectivo":
                precio = precio;
                Console.WriteLine("El precio es: " + precio);
                break;

            case "Tarjeta":
                Console.WriteLine("Ingrese el número de tarjeta:");
                string numeroTarjeta = Console.ReadLine();

                precio = precio;
                Console.WriteLine("El precio es: " + precio);
                break;

            default:
                Console.WriteLine("Forma de pago no válida.");
                break;
        }
    }
}
