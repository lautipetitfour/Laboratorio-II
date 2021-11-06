using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesVolador
{
    class Pato: Ivolador 
    {
        private int energia=100;
        public void volador()
        {
            energia -= 3;
            Console.WriteLine("Estoy volando soy un patito feo");
        }

    }
}
