using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice
{
    class demo
    {
        public void swap<T>(ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }
    }
    internal class Program
    {  
        static void Main(string[] args)
        {
            demo demo = new demo();
            int a = 15;
            int b = 25;
            demo.swap(ref a, ref b);
            Console.WriteLine("A value is"+a +" B value is "+b);
            Console.ReadLine();
        }
    }
}
