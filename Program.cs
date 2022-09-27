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
            //Realizar un programa que haga el calculo del área y perímetro de un rectangulo
            double altura, ancho, area, perimetro;


            //Pedimos la altura y leemos la altura
            Console.Write("Ingrese la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //Pedimos la base y leemos la base
            Console.Write("Ingrese el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            //Calculamos el Área
            area = altura * ancho;

            //Calculamos el Perímetro
            perimetro = 2 * (altura + ancho);

            //Mostramos el resultado
            Console.WriteLine("El aréa de su rectangulo es {0} y el perímetro {1}", area, perimetro);
        }
    }
}
