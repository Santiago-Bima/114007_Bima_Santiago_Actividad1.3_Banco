using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banco.Dominio;

namespace banco
{
    internal class Cuenta
    {
        private int cbu;
        private int tipoCuenta;
        private int cliente;
        private int activo;


        public int pCbu
        {
            get { return cbu; }
            set { cbu = value; }
        }

        public int pTipoCuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
        }

        public int pCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public int pActivo
        {
            get { return activo; }
            set { activo = value; }
        }
        public Cuenta()
        {
            cbu= 0;
            tipoCuenta= 0;
            cliente= 0;
            activo = 1;
        }

        public Cuenta(int cbu, int tipoCuenta, int cliente, int activo)
        {
            this.cbu = cbu;
            this.tipoCuenta = tipoCuenta;
            this.cliente = cliente;
            this.activo = 1;
        }
        public override string ToString()
        {
            return cbu + " - "  + tipoCuenta + " - " + cliente ;
        }
    }
}
