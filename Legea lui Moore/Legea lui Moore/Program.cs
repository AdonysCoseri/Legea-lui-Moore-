using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Legea_lui_Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,rez;
            double  c = 0.11;
            n = int.Parse(Console.ReadLine());
            rez = (int)(n / c);
            Console.WriteLine(rez);
            Console.ReadKey();
            

        }
    }
}
