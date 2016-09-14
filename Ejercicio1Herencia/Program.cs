using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura miFactura = new Factura();

            List<Documento> milistado = new List<Documento>();

            milistado.Add(miFactura);

            Remito unRemito = new Remito();

            milistado.Add(unRemito);

            foreach (Documento item in milistado)
            {
                item.Mostrar();
            }

            Console.ReadKey();
        }
    }
}
