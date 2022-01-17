using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите 7 сифр");
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            double x = 0;
            foreach (var i in a)
            {
                x += Convert.ToInt32(i);
            }
            double sr = x / a.Length;
            Console.WriteLine(sr);
        }
    }
}
/*
int[] array = new int[7] {2,4,5,6,7,8,9};
*/