internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Funcionó la app");
    }
}

class ClaseBase // se elimina sealed porque abajo se hereda
{
    public void test() 
    { 

    }

    public void moreTesting()
    {

    }
}
class ClaseHijo : ClaseBase
{

}
