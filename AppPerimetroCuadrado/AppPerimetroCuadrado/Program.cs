using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            float perimetro, lado;
            Console.Write("Programa que Calcula el Perimetro de un Cuadrado\n");
            Console.Write("Digite lado:");
            lado = float.Parse(Console.ReadLine());
            perimetro = lado * 4;
            Console.Write("El perimetro:"+perimetro);
            Console.ReadKey();

        }
    }
}
