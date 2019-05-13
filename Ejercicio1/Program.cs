using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, numInv;
            Console.Write("Ingrese un número");
            num = int.Parse(Console.ReadLine());
            numInv = Invertir(num);
            Console.Write("El número invertido es: ");
            Console.Write(numInv);
            Console.ReadKey();
        }
        static public int Invertir(int numero)
        {
            int invertido = 0;

            while (numero > 0)
            {
                invertido = (invertido * 10) + (numero % 10);
                numero = numero / 10;
            }

            return invertido;
        }
    }
}
