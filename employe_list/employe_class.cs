using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employe_list
{
     class employe_class
    {
        public int empno{ get; set; }
        public string empname{  get; set; }
        public double empbasic{ get; set; }

    public override string ToString()
    {
        return "employe number is : " + empno + "\nemployee name is : " + empname + "\nemployee Basic is : " + empbasic +"\n";
    }

    }

}
