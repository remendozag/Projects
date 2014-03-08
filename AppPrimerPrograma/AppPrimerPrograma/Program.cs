using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            Console.Write("Ingrese el primer valor:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor:");
            num2 = int.Parse(Console.ReadLine());
            suma = num1 + num2;
            producto = num1 * num2;
            Console.Write("La suma de los valores es:"+"\n"+suma+"\n");
            Console.Write("La producto de los valores es:" + "\n" + producto + "\n");
            Console.ReadKey();




        }
    }
}
