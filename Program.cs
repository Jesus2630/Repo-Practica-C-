using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 =  8;
            double numero2 = 4.2;
            double resultado;

            //Sumamos
            resultado = numero1 + numero2;

            //Operadores Aritmeticos

            //Concatenación
            string saludo = "Hola";
            string nombre = "Jesús";

            //Operadores Básicos
            /* Console.WriteLine(20 - 2);
            Console.WriteLine(20 + 2);
            Console.WriteLine(20 * 2);
            Console.WriteLine(20 / 2); */

            //Operador de División

            //Float
            Console.WriteLine(16.8f / 4.1f);
            //Double
            Console.WriteLine(16.8d / 4.1d);
            //Decimal
            Console.WriteLine(16.8m / 4.1m);

            //Resto
            Console.WriteLine(5 % 2);
            Console.WriteLine(5.9 % 3.1);
        }
    }
}
