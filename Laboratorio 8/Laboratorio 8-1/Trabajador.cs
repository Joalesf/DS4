class Trabajador : Persona
{
    public int Sueldo;

    //Modifique trabajador a publico para que pueda ser accedido desde Program.cs
    public Trabajador(string nombre, int edad, string nif, int sueldo) : base(nombre, edad, nif)
    {
        Sueldo = sueldo;
    }
}
