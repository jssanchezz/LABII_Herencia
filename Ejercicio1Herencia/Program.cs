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
            Factura miFactura = new Factura(666);

            List<Documento> milistado = new List<Documento>();

            milistado.Add(miFactura);

            Remito unRemito = new Remito(999);

            FacturaA mifacturaA = new FacturaA(21, miFactura);

            FacturaAPagada facturaPagada = new FacturaAPagada("Hoy", mifacturaA);

            milistado.Add(unRemito);

            foreach (Documento item in milistado)
            {
                item.Mostrar();
            }

            Console.ReadKey();
        }
    }
}
