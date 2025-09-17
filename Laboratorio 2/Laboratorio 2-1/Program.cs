using System;

namespace Laboratorio_2_1 //Laboratorio2.1 José Sánchez 
{
    public class Program
    {
        static void Main()
        {
        //Variable Static
        MyClass.Valor = 10; //Cambie el valor de la variable estática
        Console.WriteLine(MyClass.Valor);
        }
    }
    public class MyClass
    {
        public static int Valor;
    }
}