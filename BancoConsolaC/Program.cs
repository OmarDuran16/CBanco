using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClasesBancoCSharp;

namespace BancoConsolaC
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta Cuenta1;

            Cliente Cliente1 = new Cliente();  //se crea al usuario
            Console.WriteLine("ingrese su nombre");
            Cliente1.Nombre = Console.ReadLine();
            Console.WriteLine("ingrese su Apellido");
            Cliente1.Apellido = Console.ReadLine();

            Console.WriteLine("se creara una cuenta (0 = soles, 1 = dolares )");
            TipoMoneda Moneda = int.Parse(Console.ReadLine()) == 1 ? TipoMoneda.Soles : TipoMoneda.Dolares;
            Cuenta1 = Cliente1.CrearCuenta(Moneda);

            Console.WriteLine("ingrese monto a depositar");
            decimal monto = decimal.Parse(Console.ReadLine());
            Deposito Deposito1 = new Deposito(monto, Moneda);
            Deposito1.Ejecutar(Cuenta1);


            //Cuenta1 = new Cuenta(TipoMoneda.Soles);
            
            Console.WriteLine("Cuenta {0}", Cuenta1.NumeroCuenta);
            Console.WriteLine("Apertura en {0}", Cuenta1.FechaApertura);
            Console.WriteLine("Moneda en {0}", Cuenta1.Moneda);
            Console.WriteLine("Saldo: {0}", Cuenta1.Saldo);
            Console.Read();
        }
    }
}
