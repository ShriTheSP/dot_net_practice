using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice_1
{
    class Employe
    {
        public int empno {get; set; }
        public string empname { get; set; }

        public double basic{ get; set;}



        public override string ToString()
        {
            return "employee no : " + empno + "\nemployee name : " + empname + " \nbasic :  " + basic;
        }
    }
}
