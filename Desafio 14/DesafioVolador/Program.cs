using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesVolador
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato patito = new Pato();
            Boing_737 boing = new Boing_737();
            Superman s = new Superman();
            TorreControl Dallas = new TorreControl();
            Dallas.agregarVolador(patito);
            Dallas.agregarVolador(boing);
            Dallas.agregarVolador(s);

            Dallas.vuelanTodos();
            Console.ReadKey();
        }
    }
}
