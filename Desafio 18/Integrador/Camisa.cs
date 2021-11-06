using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Camisa : Ropa
    {
        private bool mangaCorta;

        public Camisa(int cantidad, double precio )
            : base(cantidad, precio)
        {          
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public Camisa (bool mangaCorta, int cantidad, double precio, bool standard, bool premium)
            :base(cantidad, precio,standard, premium)
        {
            this.mangaCorta = mangaCorta;
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

            if(mangaCorta == true)
            {
                precioFinal = precioFinal * 0.9;
            } 

            if (premium == true)
            {
                precioFinal = precioFinal * 1.3;
            }

            precioFinal = precioFinal * cantidad;

            return (double)precioFinal;
        }

    }
}
