using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reza_alikhanbeigi_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a, mohit, masahat;

            Console.Write("Enter a number for radius: ");
            a = Double.Parse(Console.ReadLine()); 

            mohit = 2 * 3.14 * a; 
            masahat = 3.14 * a * a;

            Console.WriteLine("Masahat is {0} and Mohit is {1}", masahat, mohit);

            Console.ReadKey();
        }
    }
}