using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Herencia
{
    public class FacturaA:Factura
    {
        int iva;

        public FacturaA(int iva, Factura unaFactura)
            : base(unaFactura.numero, unaFactura.fecha, unaFactura.numeroDeControl)
        {
            this.iva = iva;
        }
    }
}
