using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco.Dominio
{
    internal class Transaccion
    {
        private int idCuenta;
        private DateTime fecha;
        public List<Movimiento> Movimiento { get; set; }

        public int IdCuenta
        {
            get { return idCuenta; }
            set { idCuenta = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public Transaccion()
        {
            Movimiento = new List<Movimiento>();
        }

        public void AgregarMovimiento(Movimiento movimiento)
        {
            Movimiento.Add(movimiento);
        }

        public void QuitarMovimiento (int indice)
        {
            Movimiento.RemoveAt(indice);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (Movimiento item in Movimiento)
            {
                total += item.Monto;
            }
            return total;
        }
    }
}
