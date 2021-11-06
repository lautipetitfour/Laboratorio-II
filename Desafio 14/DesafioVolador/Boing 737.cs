using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesVolador
{
    class Boing_737: Ivolador
    {
        private int horasVuelo=0;
        public void volador()
        {
            horasVuelo += 13;
            Console.WriteLine("Estoy volando en el avion mas grande de todos");
        }

    }
}
