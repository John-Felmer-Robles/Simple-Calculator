using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float P, r, n;
            double A;

            Console.WriteLine("Investment Amount: ");
            P = float.Parse(Console.ReadLine());

            Console.WriteLine("Rate of Investment(per year): ");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("Duration of Fixed Deposit: ");
            n = float.Parse(Console.ReadLine());

            double x = Math.Pow(1 + (r / 100), n);

            A = P * x;

            Console.WriteLine(A);

            Console.ReadLine();
        }

    }
}
