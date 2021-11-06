using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Pantalon : Ropa
    {
        private bool bermuda;

        public Pantalon(int cantidad, double precio)
            : base(cantidad, precio)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }
        
        public Pantalon(bool bermuda, int cantidad, double precio, bool standard, bool premium)
            : base(cantidad, precio, standard, premium)
        {
            this.bermuda = bermuda;
            this.cantidad = cantidad;
            this.precio = precio;
            this.standard = standard;
            this.premium = premium;
        }

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        override
        public double CalPrecioFinal()
        {
            double precioFinal = precio;

            if (bermuda)
            {
                precioFinal = precioFinal * 0.8;  
            }

            if (premium)
            {
                precioFinal = precioFinal * 1.3;
            } 
 
            precioFinal = precioFinal * cantidad;

            return (double)precioFinal;
        }
    }
}
