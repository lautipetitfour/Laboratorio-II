using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito_compras
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc, aux;
            Camisa miCamisa = new Camisa();
            char salir;
            do
            {
                do
                {

                    Console.WriteLine("Venta de Camisas");
                    miCamisa.sacarTotalMenu();
                    Console.WriteLine("MENU PRINCIPAL \n 1 : Añadir camisa al carro compras \n 2 : Eliminar camisa carro compras \n 3 : Salir");
                    Console.WriteLine("Eliga una opcion");

                    opc = Convert.ToInt32(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            {
                                miCamisa.agregarCamisa();
                                Console.Clear();
                                break;

                            }
                        case 2:
                            {
                                miCamisa.eliminarCamisa();
                                Console.Clear();
                                break;
                            }

                    }


                } while (opc != 3);
                Console.WriteLine("Desea salir del programa");
                Console.WriteLine("S : salir");
                Console.WriteLine("N : volver a ejecutarlo");
                salir = Convert.ToChar(Console.ReadLine());
                if (salir == 'S' || salir == 's')
                {
                    aux = 1;
                } else aux =2;
                Console.Clear();
                
            } while (aux != 1);
        }
    }
}
