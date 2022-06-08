using Intfaceysobr.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intfaceysobr
{
    class Program
    {
        static void Main(string[] args)
        {

            var trago = new Cerveza(1);
            var trago2 = new Ron(1);
            var trago3 = new Vodka(1);

            //sobrecarga 

            trago.Recomendado("");

            MostrarRecomendado(trago);
            MostrarRecomendado(trago2);
            MostrarRecomendado(trago3);
            Console.WriteLine("");
            //parte metodo por defecto 
            //en que metodo lo vamos a usar en este caso con la cerveza
            ((ITraguito)trago).Recomendado();            

            Console.ReadKey();
        }
        static void MostrarRecomendado(ITraguito traguito)
        {
            traguito.Recomendado();
        }
    }
}
