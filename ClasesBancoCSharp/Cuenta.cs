using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBancoCSharp
{
    public enum EstadoCuenta  //enumeramos los diferentes tipos que tomara estado
    {
        Activa,  //estos valores A B C son opcionales es solo para valor interno
        Bloqueada,
        Cerrada
    }

    public enum TipoMoneda
    {
        Soles,
        Dolares
    }

    public class Cuenta
    {
        private DateTime _FechaApertura; //guarda fecha apertura lo protege
        private int _NumeroCuenta;  //igual con numero cuenta
        private TipoMoneda _moneda; //esta es la variable que guarda moneda, usa enumeracion ver arriba
        private EstadoCuenta _Estado;
        private decimal _Saldo;

        public int NumeroCuenta
        {
            get { return this._NumeroCuenta; }
        }
        public DateTime FechaApertura 
        {
            get { return this._FechaApertura; }
        }
        public EstadoCuenta Estado 
        {
            get { return this._Estado; }   //cuenta activa o no activa
        } 
        public TipoMoneda Moneda 
        {
            get { return this._moneda; }  //este utiliza como consulta guarda lo mismo que _moneda
        }
        public decimal Saldo 
        {
            get { return this._Saldo; }
        }


        public Cuenta(TipoMoneda moneda) {    //este es el constructor
            this._NumeroCuenta = 0;
            this._moneda = moneda;
            this._FechaApertura = DateTime.Now;
            this._Estado = EstadoCuenta.Activa;
            this._Saldo = 0;
        }



        public void SumarSaldo(decimal monto)   //operacion usada en los depositos
        {
            this._Saldo += monto;
        }

        public void RestarSaldo(decimal monto)  //operacion usada en retiro
        {
            this._Saldo -= monto;
        }

        public decimal ConsultarSaldo()  //solo saber cuanto tiene de saldo
        {
            return this.Saldo;
        }

        public override string ToString()  //ejemplo de sobreescribir un metodo virtual
        {
            return String.Format("Cuenta {0} con saldo {1}",this._NumeroCuenta,this._Saldo);
        }

    }
}
