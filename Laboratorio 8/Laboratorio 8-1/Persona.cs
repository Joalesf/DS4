class Persona
{
    public string Nombre;
    public int Edad;
    public string NIF;

    void Cumpleaños()
    {
        Edad++;
    }
    //Constructor
    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }
}