using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Herencia
{
    public class Documento
    {
        public int numero;
        public string fecha;
        public int numeroDeControl;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public Documento(int numero, string fecha, int numControl)
            : this(numero)
        {
            this.numeroDeControl = numControl;
            this.fecha = fecha;
        }

        public void Mostrar()
        {
            Console.WriteLine(this.numero);
            Console.WriteLine(this.fecha);
            Console.WriteLine(this.numeroDeControl);
        }
    }
}
