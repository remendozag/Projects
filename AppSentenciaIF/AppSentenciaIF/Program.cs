using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que lea por teclado dos números, 
 * si el primero es mayor al segundo informar su suma y 
 * diferencia, en caso contrario informar el producto y la 
 * división del primero respecto al segundo.*/
namespace AppSentenciaIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, diferencia, producto, division;
            Console.WriteLine("Digite numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite numero 2");
            num2 = int.Parse(Console.ReadLine());
            if(num1>num2){
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.WriteLine("La suma es:"+suma);
                Console.WriteLine("La diferencia es:" + diferencia);
            }else{
                producto = num1 * num2;
                division = num1 / num2;
                Console.WriteLine("La producto es:" + producto);
                Console.WriteLine("La division es:" + division);
            }
            Console.ReadKey();
            //fin del codigo



        }
    }
}
