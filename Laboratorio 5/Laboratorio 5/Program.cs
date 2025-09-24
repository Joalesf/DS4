internal class ProgramOP
{
    private int[] sueldos;
    public void cargar()
    {
        //José Sánchez 8-1032-2111  1GS-222
        //Ejemplo 5.1: Cargar y mostrar sueldos de 5 operarios.
        sueldos = new int[6];
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + f + ": ");
            String linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    public void imprimir()
    {
        Console.Write("Los 5 sueldos de los operarios \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("[" + sueldos[f] + "]");
        }
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        ProgramOP pv= new ProgramOP();
        pv.cargar();
        pv.imprimir();
    }
}