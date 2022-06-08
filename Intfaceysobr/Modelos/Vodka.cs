using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intfaceysobr.Modelos
{
    
    class Vodka : Bebida, ITraguito
    {
        public int Alcohol { get; set; }

        public void Recomendado()
        {
            Console.WriteLine("Minimo la botella de Vodka: {0}", 1);
        }
        public Vodka(int Cantidad, string Nombre = "Vodka") : base(Nombre, Cantidad)
        {
        }


    }
}
