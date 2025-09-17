using System;

namespace Laboratorio_2 //Laboratorio2 José Sánchez - Variables de Instancia
{
    class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        client.FirstName = "José ";
        client.LastName = "Sánchez";
        client.Age = 19;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());
    }
}
}

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}