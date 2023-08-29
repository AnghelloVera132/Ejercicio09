using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            int number3 = int.Parse(Console.ReadLine());
            if ((number1 > number2) && (number1 > number3))
            {
                Console.WriteLine("El primero es mayor");
            }
            else if ((number2 > number1) && (number2 > number3))
            {
                Console.WriteLine("El segundo es mayor");
            }
            else if ((number3 > number1) && (number3 > number2))
            {
                Console.WriteLine("El tercero es mayor");
            }
            Console.ReadKey();
        }
    }
}
