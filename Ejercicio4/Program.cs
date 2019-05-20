using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena, cad1;

            Console.WriteLine("Ingrese una cadena de texto: ");
            cadena = Console.ReadLine();

            string Mayusc = cadena.ToUpper();
            string minus = cadena.ToLower();
            int longitud = cadena.Length;
            Console.WriteLine("La longitud de la cadena es: {0}", longitud);
            Console.WriteLine(Mayusc);
            Console.WriteLine(minus);
            Console.WriteLine("Ingrese otra cadena de texto: ");
            cad1 = Console.ReadLine();
            var S = String.Concat(cadena, cad1);
            Console.Write(S);
            string.Compare(cadena, cad1);

            Console.ReadKey();
        }
    }
}
