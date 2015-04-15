using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public abstract class Operacion  //molde donde aqui se instanciaran usaremos los metodos 
    {
        protected int NumOperacion { get; set; }
        protected DateTime FechaOperacion { get; set; }
        protected TipoMoneda Moneda { get; set; }
        protected decimal Monto { get; set; }

        public virtual string ConsultarOperacion() { return ""; }  //tiene codigo para sobreescribir en subclases
        public abstract bool Ejecutar(Cuenta cuenta);  //abstracto no tiene codigo las que heredan si tendra codigo ejecutar

        //una regla dice que en clases abstractas debe haber metodos abstractos
    }
}
