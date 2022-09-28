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
            
            //Programa para calcular el perimetro de cualquier poligono regular. 

            int lados;
            double tamaño, perimetro;

            //Pido cantidad de lados
            Console.Write("Cuantos lados tiene tu polígono: ");
            lados = Convert.ToInt32(Console.ReadLine());

            //Pido el tamaño de los lados
            Console.Write("Ingrese el tamaño de los lados: ");
            tamaño = Convert.ToDouble(Console.ReadLine());

            //Calculo el perimetro
            perimetro = tamaño * lados;

            //Muestro el resultado
            Console.WriteLine("El perimetro de su poligono es: {0}", perimetro);

        }
    }
}
