using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employe_list
{
    class Program
    {
        static List<employe_class> employelist;

        static Program()
        {
            employelist = new List<employe_class>();
        }
        public string addemploye(employe_class employe)
        {
            employelist.Add(employe);
            return "Added successfully";
        }
        public void addemployeinput()
        {
            employe_class employe=new employe_class();
            Console.WriteLine("enter employe number :");
            employe.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employe name :");
            employe.empname=Console.ReadLine();
            Console.WriteLine("enter basic :");
            employe.empbasic=Convert.ToDouble(Console.ReadLine());
            addemploye(employe);
        }
        public void showemploye()
        {
            foreach(employe_class e in employelist)
            {
                Console.WriteLine(e);
            }


        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            int ch;
            do
            {
                Console.WriteLine("-- OPTIONS -- ");
                Console.WriteLine("1 . Add new employe \n2 . Show employe details \n3 . Exit \n \nEnter your option : ");
                ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    obj.addemployeinput();
                    break;
                case 2:
                    obj.showemploye();
                    break;

                default:
                    Console.WriteLine("please enter valid option");
                    break;
            }

            } while (ch != 3);
        }
    }
}
