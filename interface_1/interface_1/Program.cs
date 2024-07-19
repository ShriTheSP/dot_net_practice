using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_1
{
    interface training
    {
        void name();
        void email();

    }

    class shri : training
    {
        public void email()
        {
            Console.WriteLine("email is shri@email");
        }

        public void name()
        {
            Console.WriteLine("name is shridhar");
        }
    }

    class pruthvi : training
    {
        public void email()
        {
            Console.WriteLine("email is prthvi@email");
        }
        public void name()
        {
            Console.WriteLine("name is pruthvi");

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
