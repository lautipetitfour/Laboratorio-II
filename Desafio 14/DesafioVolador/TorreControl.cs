using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesVolador
{
    class TorreControl
    {
        
        ArrayList TorreControl = new ArrayList();


        public void agregarVolador(Ivolador a)
        {
            TorreControl.Add(a);
        }

        public void vuelanTodos()
        {
            foreach( Ivolador i in TorreControl)
            {
                i.volador();
            }
        }

    }
}
