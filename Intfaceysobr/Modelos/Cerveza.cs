using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intfaceysobr.Modelos
{
    //se pueden agragar mas interfaces para que cumpla la multiherencia
    class Cerveza : Bebida ,ITraguito
    {
        public int Alcohol { get; set; }
        //metodo
        public void Recomendado()
        {
            Console.WriteLine("Minimo la java de Pilsener: {0}",12);
        }
        //metodo sobreescristo
        public void Recomendado(string Param)
        {
            Console.WriteLine("Java de Cerveza de sobrecarga",Param);
        }

        public Cerveza(int Cantidad, string Nombre="Pilsener") : base(Nombre, Cantidad) 
        { 
        }

        
    }
}
