using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, num1, num2;

            Console.Write("Ingrese un número: ");
            num = double.Parse(Console.ReadLine());
            double valorAbs = Math.Abs(num);
            double cuadrado = Math.Pow(num, 2);
            double raiz = Math.Sqrt(num);
            double seno = Math.Sin(num);
            double coseno = Math.Cos(num);
            double parteEntera = Math.Truncate(num);

            Console.WriteLine("Valor Absoluto: {0}", valorAbs);
            Console.WriteLine("Cuadrado: {0}", cuadrado);
            Console.WriteLine("Raíz cuadrada: {0}", raiz);
            Console.WriteLine("Seno: {0}", seno);
            Console.WriteLine("Coseno: {0}", coseno);
            Console.WriteLine("Parte entera: {0}", parteEntera);

            Console.WriteLine("Ingrese dos números: ");
            Console.Write("Número 1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            num2 = double.Parse(Console.ReadLine());

            double MAX = Math.Max(num1, num2);
            double min = Math.Min(num1, num2);

            Console.WriteLine("El máximo es: {0}", MAX);
            Console.WriteLine("El mínimo es: {0}", min);

            Console.ReadKey();
        }
    }

            
        
    
}
