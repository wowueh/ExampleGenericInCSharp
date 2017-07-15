using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void InRaManHinh<T>(T any)
        {
            Console.WriteLine(any);
        }

        static void Main(string[] args)
        {
            int a = 10;
            char b = 'C';
            string c = "Ho Duc Nhat Thanh";
            bool d = true;
            float e = 50.45f;
            decimal f = 45.56m;
            InRaManHinh<int>(a);
            InRaManHinh<char>(b);
            InRaManHinh<string>(c);
            Console.ReadKey();
        }
    }
}
