using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, RESULTADO;
            string operacion,resp;

            Console.WriteLine("Seleccione la operación: ");
            Console.WriteLine("+ para SUMAR");
            Console.WriteLine("- para RESTAR");
            Console.WriteLine("/ para DIVIDIR");
            Console.WriteLine("* para MULTIPLICAR");
            Console.Write("Operación: ");
            operacion = Console.ReadLine();
            string OPERACION = Convert.ToString(operacion);
            Console.WriteLine("Ingrese dos números;");
            Console.Write("Número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            num2 = int.Parse(Console.ReadLine());

            switch (OPERACION)
            {
                case "+":
                    Console.WriteLine("El resultado de la SUMA es:");
                    RESULTADO = num1 + num2;
                    Console.WriteLine("{0} = {1} + {2}", RESULTADO, num1, num2);
                    break;
                case "-":
                    Console.WriteLine("El resultado de la RESTA es:");
                    RESULTADO = num1 - num2;
                    Console.WriteLine("{0} = {1} - {2}", RESULTADO, num1, num2);
                    break;
                case "/":
                    Console.WriteLine("El resultado de la DIVISION es:");
                    RESULTADO = num1 / num2;
                    Console.WriteLine("{0} = {1} / {2}", RESULTADO, num1, num2);
                    break;
                case "*":
                    Console.WriteLine("El resultado de la RESTA es:");
                    RESULTADO = num1 * num2;
                    Console.WriteLine("{0} = {1} * {2}", RESULTADO, num1, num2);
                    break;
            }
            Console.WriteLine("¿Desea realizar otra operación?");
            resp = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
