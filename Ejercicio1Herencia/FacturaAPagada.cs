using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Herencia
{
    public class FacturaAPagada:FacturaA
    {
        public string fechaDePago;

        public FacturaAPagada(string fechaDePago, FacturaA unaFactura)
            : base(21, unaFactura)
        {
            this.fechaDePago = fechaDePago;
        }
    }
}
