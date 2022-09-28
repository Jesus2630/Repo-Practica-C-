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
            //Declaramos las variables a utilizar
            double centigrados;
            double fahrenheit;

            //Pedimos la temperatura a convertir
            Console.Write("Ingrese la temperatura a convertir: ");
            centigrados = Convert.ToDouble(Console.ReadLine());

            //Hacemos el calculo
            fahrenheit = (1.8 * centigrados) + 32;

            //Mostramos el resultado
            Console.WriteLine("La temperatura ingresada son {0} en Fahrenheit", fahrenheit);
        }
    }
}
