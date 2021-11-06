using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesVolador
{
    class Superman: Ivolador
    {
        private int xp = 0;
        public void volador()
        {
            Console.WriteLine("Puedo volar coomooo supeermaaaaaan");
            xp += 3;
        }
    }
}
