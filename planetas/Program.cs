using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double marte = 3.711;
            double jupiter = 24.79;
            Console.WriteLine("Cuanto Pesas En Otro Planeta?");
            Console.WriteLine("Inserta Tu Peso Terrestre Actual");
            string peso;
            peso= Console.ReadLine();
            if( Int32.Parse(peso) >= 90)
            {
              Console.WriteLine("Tienes Sobre Peso");
            }
            string opcion;
            Console.WriteLine("Escoge un plante [MARTE O JUPITER]");
            opcion = Console.ReadLine();
            if (opcion.ToLower() == "marte") {
                double result = Int32.Parse(peso) / 9.801 * marte ;
                Console.WriteLine(result);
            }

            if(opcion.ToLower() == "jupiter")
            {
                double result = Int32.Parse(peso) / 9.801 * jupiter;
                Console.WriteLine(result);
            }
     
        }
            
    }
}

