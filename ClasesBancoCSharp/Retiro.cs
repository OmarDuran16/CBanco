using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class Retiro:Operacion
    {
        public Retiro(decimal monto, string moneda)  //constructor que llama los datos de cuenta
        {
            this.NumOperacion = 0;
            this.FechaOperacion = DateTime.Now;
            this.Monto = Monto;
            this.Moneda = Moneda;
        }

        public override bool Ejecutar(Cuenta cuenta)  //especifiquemos override por ser metodo abstracto
        {
            if (cuenta.Moneda == this.Moneda)  //haberiguamos el tipo de moneda
            {
                cuenta.RestarSaldo(this.Monto);  //se resta dinero por hacer un retiro
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
