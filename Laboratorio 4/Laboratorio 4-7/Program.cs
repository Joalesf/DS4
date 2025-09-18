class Program
{
    static void Main(string[] args)
    {
        int numeroUno = 70;
        double numeroDos = 67.89;
        double numeroTres = 67.89;

        Console.WriteLine(Suma(numeroUno, numeroDos)); //solo a 2 decimales
        Console.WriteLine(Suma(numeroUno, numeroDos, numeroTres));// da mas de 4 ecimales, pero porque sucede esto?

        //2 sumas realizadas
    }

    static double Suma(int x, double y, double z = 0) // se crea el metodo "creo" e suma, para que sea valido y lo pueda leer
    {
        return x + y + z;
    }
}
