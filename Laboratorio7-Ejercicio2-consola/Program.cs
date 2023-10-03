using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_Ejercicio2_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Divisor de Omar Orlandini " + num + " : " + i);
                    num++;
                }
            }
            Console.ReadKey();
        }
    }
}
