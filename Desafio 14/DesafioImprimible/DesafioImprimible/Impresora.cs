using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesImprimible
{
    class Impresora
    {
        ArrayList cola = new ArrayList();
        public void AgregarImprimible(Imprimible a)
        {
            cola.Add(a);

        }
        public void ImprimirTodo()
        {
            foreach (Imprimible i in cola) {
                i.Imprimir();
            }
        }

    }
}
