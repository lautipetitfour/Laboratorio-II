using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Carrito_compras
{
    class Camisa
    {
        private double precio = 1000;
        private double cantCamisas=0;
        private double subtotal=0;

        public void agregarCamisa()
        {
            cantCamisas += 1;
            subtotal += 1000;
            Console.WriteLine(" Se agrego una ca,isa al carrito de compras");
            Thread.Sleep(300);
            Console.Clear();


        }

        public void eliminarCamisa()
        {
            cantCamisas -= 1;
            subtotal -= 1000;
            Console.WriteLine(" Se elimino una camisa del carrito de compras");
            Thread.Sleep(300);
            Console.Clear();


        }

        public void sacarTotalMenu()
        {
            double descuento;
            double total;

            Console.WriteLine("Cantidad de camisas en el carrito: " + cantCamisas);
            Console.WriteLine("Precio por cada prenda: " + precio);
            Console.WriteLine("El subtotal sin descuento es: " + subtotal);

            if(cantCamisas>2 && cantCamisas <= 5)
            {
                descuento = subtotal * 0.10;
                total = subtotal - descuento;
                Console.WriteLine("El descuento es de 10%");
                Console.WriteLine("El total con descuento es: "+ total);
            }else if (cantCamisas > 5)
            {
                descuento = subtotal * 0.20;
                total = subtotal - descuento;
                Console.WriteLine("El descuento es de 20%");
                Console.WriteLine("El total con descuento es: " +total);
            }
            else
            {
                total = subtotal;
                Console.WriteLine("Sin descuento");
                Console.WriteLine("El total con descuento es: "+ total);
            }   
        }
    }
}
