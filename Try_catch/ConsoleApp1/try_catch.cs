using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class try_catch
    {
        public void Check(int n)
        {
            if (n == 0)
            {
                throw new DivideByZeroException("Zero number is not accepted");
            }
            else if (n < 0)
            {
                throw new IndexOutOfRangeException("Negative number is not allowed");
            }
            else
            {
                Console.WriteLine("The number is {0}", n);
            }
        }

            static void Main(string[] args)
        {
            int n;
            try_catch obj = new try_catch();
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            try
            {
                obj.Check(n);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
