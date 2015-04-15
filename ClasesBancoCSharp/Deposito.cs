using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class Deposito:Operacion
    {
        public Deposito(decimal monto, TipoMoneda moneda)  //constructor que llama los datos de cuenta
        {
            this.NumOperacion = 0;
            this.FechaOperacion = DateTime.Now;
            this.Monto = Monto;
            this.Moneda = moneda;
        }

        public override bool Ejecutar(Cuenta cuenta) 
        {
            if (cuenta.Moneda == this.Moneda) //el if hace uso de buscar el tipo de moneda
            {  //lo confirma y entra
                cuenta.SumarSaldo(this.Monto);  //sabiendo el tipo de moneda se suma el saldo
                return true;
            } else {
                return false;
            }
        }
    }
}
