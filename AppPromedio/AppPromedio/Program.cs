using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, suma, promedio;
            Console.Write("Digite primer valor\n");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite segundo valor\n");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("Digite tercer valor\n");
            num3 = double.Parse(Console.ReadLine());
            Console.Write("Digite cuarto valor\n");
            num4 = double.Parse(Console.ReadLine());
            suma = (num1 + num2 + num3 + num4);
            promedio=suma/ 4;
            Console.WriteLine("La suma de los valores es: \n" + suma);
            Console.WriteLine("La promedio de los valores es: \n" + promedio);
            Console.ReadKey();

        }
    }
}
