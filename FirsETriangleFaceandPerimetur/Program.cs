using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsETriangleFaceandPerimetur
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());

            // proverka za triugulnik     

            if ((a + b)<=c || (a + c) <= b || (c + b) <= a)
            {
                Console.WriteLine(" This triange dose't exsist ");
            }

            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));





        }
    }
}
