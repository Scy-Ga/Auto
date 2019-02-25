using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Classes
{
    class SUV : ClaszikusVarosiAuto
    {
        public int hasmagasaság { get; set; } // földtől való magasság



        public SUV(string ü, string m, string sz, double h, string sv, int s, int a, int k, int csm, string lt, string ex, int hm) : base(ü, m, sz, h, sv, s, a, k, csm, lt, ex)
        {
            hasmagasaság = hm;
        }


        
    }
}
