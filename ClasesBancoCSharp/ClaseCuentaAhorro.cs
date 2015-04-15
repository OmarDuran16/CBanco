using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class ClaseCuentaAhorro:Cuenta
    {
        public ClaseCuentaAhorro(TipoMoneda moneda)  //este constructor usa lo de cuenta y lo complementa
           :base(moneda)
        {
        }
    }
}
