using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice_1
{
    class Demo
    {
        static List<Employe> employeList;
        static Demo()
        {
            employeList = new List<Employe>();
        }
        public string addemploye(Employe employe)
        {
            employeList.Add(employe);
            
            return "employe record added successfully..";
        }

        public void showemploye()
        {
            foreach(Employe e in employeList)
            {
                Console.WriteLine(e);
            }
        }

        public void addemployeinput()
        {
            Employe employe = new Employe();
            Console.WriteLine("enter employe Id : ");
            employe.empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employe name : ");
            employe.empname=Console.ReadLine();
            Console.WriteLine("enter basic : ");
            employe.basic=Convert.ToDouble(Console.ReadLine());
           Console.WriteLine(addemploye(employe));

        }
        static void Main(string[] args)
        {
            Demo demo =new Demo();
            int ch;
            do
            {
                Console.WriteLine(" ---OPTIONS---");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Add Employe");
                Console.WriteLine("2. show Employe");
                Console.WriteLine("3. Exit");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        demo.addemployeinput(); 
                        break;
                    case 2:
                        demo.showemploye();
                        break;
                    default:
                        Console.WriteLine("Invalid option, Please enter correct option");
                        break;
                }
            } while (ch != 3);
        }
    }
}
