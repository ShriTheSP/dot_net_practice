using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
     public class demo
    {
        public void check_even_odd()
        {
            Console.WriteLine("please enter a number :");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("Enter a Non Zero number");
            else
            {
                Console.WriteLine("Its a non zero number ");
                if (n < 0) Console.WriteLine("its a negative number");
                else if (n > 0) Console.WriteLine("its a positive number");
                else Console.WriteLine("please enter an integer ");
            }
        }


        public void create_2d_aray()
        {
            Console.WriteLine("enter no of rows in array : ");
            int row=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the columns of array :");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] array2 = new int[row, col];
            for(int i=0;i<row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("enter the element of  {0} row  {1}  column of array",i+1 , j+1);
                    array2[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            string ch;
            do
            {
                Console.WriteLine("do you want to print the array you have entered  ? \n please enter yes or no :");
                 ch = Console.ReadLine();
                switch (ch)
                {
                    case "yes":
                        {
                            Console.WriteLine("The array is  ************");
                            for (int i = 0; i < row; i++)
                            {
                                for (int j = 0; j < col; j++)
                                {
                                    Console.Write(array2[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Thank you");

                        }
                        return;
                        break;

                    case "no": Console.WriteLine("Thank you ");
                        break;
                    default:
                        Console.WriteLine("enter the correct option");
                        break;
                }

            } while (ch!="no");


        }
        static void Main(string[] args)
        {
            demo obj = new demo();
            obj.check_even_odd();
            obj.create_2d_aray();
        
        }
    }
}
