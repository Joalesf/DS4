internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado= new Empleado();
        empleado.Nombre = "John Doe";
        Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Saldo = 100;
        Console.WriteLine($"El saldo de el empleado es: {cuenta.Saldo}");
        //Probe con saldo -100 y me lanza la excepcion correctamente 

        Cobertura c = new Cobertura(5);
        Console.WriteLine($"Con una covertura de: {c.Radio}");
    }
}