using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public class Cliente
    {
        protected string Dni { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nacionalidad { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Apellido { get; set; }

        public List<Cuenta> cuentas = new List<Cuenta>();  //una lista para mostrar las cuentas del cliente


        public Cuenta CrearCuenta(TipoMoneda moneda)
        {
            Cuenta NuevaCuenta = new Cuenta(moneda);
            this.cuentas.Add(NuevaCuenta);
            return NuevaCuenta;  //devuelve la nueva cuenta
        }
        public void CerrarCuenta() { }
    }
}
