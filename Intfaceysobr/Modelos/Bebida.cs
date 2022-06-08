using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intfaceysobr.Modelos
{
    class Bebida
    {
        //propiedades
        string Nombre { get; set; }
        int Cantidad { get; set; }
        //constructor
        public Bebida (string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
    }
}
