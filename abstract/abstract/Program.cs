using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract class training
    {
        public abstract void name();
        public abstract void email();

    }
    class shri : training
    {
        public override void email()
        {
            Console.WriteLine("email is shridharsp@gmail.com");
        }

        public override void name()
        {
            Console.WriteLine("name is shridhar");
        }
    }

    class pruthvi : training
    {
        public override void email()
        {
            Console.WriteLine("name is pruthvi");
        }

        public override void name()
        {
            Console.WriteLine("email is pruthvi34@gmail.email");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            training[] arr = new training[]
            {
                new shri(),new pruthvi()

            };
            foreach (training t in arr)
            {
                t.name();
                t.email();
            }
        }
    }
}
