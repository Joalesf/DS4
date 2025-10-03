using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cuenta
{
    private string idCuenta;

    public Cuenta(string prmtIdCuenta)
    {
        this.idCuenta = prmtIdCuenta;
        System.Console.WriteLine("1Constructor Clase Base  para cuenta {0}", prmtIdCuenta);
    }

    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine("1Cuenta.CalcularIntereses() efectuado para la cuenta {0}", this.idCuenta);
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}