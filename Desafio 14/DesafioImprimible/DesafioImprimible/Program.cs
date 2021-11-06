using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesImprimible
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto photo = new Foto();
            Contrato contract = new Contrato();
            Documento word = new Documento();
            Impresora imp = new Impresora();

            imp.AgregarImprimible(photo);
            imp.AgregarImprimible(word);
            imp.AgregarImprimible(contract);
            imp.ImprimirTodo();
            Console.ReadLine();
        }

        
    }
}
