using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    abstract class Ropa
    {
        protected int cantidad;
        protected double precio;
        protected bool standard;
        protected bool premium;

        protected Ropa(int cantidad, double precio)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }
        protected Ropa(int cantidad, double precio, bool standard, bool premium)
        {
            this.cantidad = cantidad;
            this.precio = precio;
            this.standard = standard;
            this.premium = premium;
        }

        public abstract double CalPrecioFinal();
    }
}
