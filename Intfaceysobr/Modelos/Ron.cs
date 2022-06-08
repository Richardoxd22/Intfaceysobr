using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intfaceysobr.Modelos
{
    class Ron : Bebida, ITraguito
    {
        public int Alcohol { get; set; }

        public void Recomendado()
        {
            Console.WriteLine("Minimo la botella de Ron: {0}", 1);
        }
        public Ron(int Cantidad, string Nombre = "Ron") : base(Nombre, Cantidad)
        {
        }


    }
}
