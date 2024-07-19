using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{
    interface I1
    {
        void name();
    }

    interface I2
    {
        void email();
    }

    class shri : I1, I2
    {
        public void name()
        {
            Console.WriteLine("name is shri");

        }
        public void email()
        {
            Console.WriteLine("email is shri@123");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shri obj = new shri();
            obj.name();
            obj.email();
        }
    }
}
