using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Classes
{
    class MainAuto
    {
        public string üzemanyag { get; set; } //benzim, gázolaj, elektromos, hibrid
        public string meghajtás { get; set; } // első- , hátsó-, összkerékmeghajtás
        public string szín { get; set; } //Az autó színe
        public double hengerÜrtertalom { get; set; } // hány ccm
        public string sebességVáltó { get; set; } // manuáli, autómata, félautómata
        public int sebesség { get; set; } // hány sebességes a váltó
        public int ajtókSzáma { get; set; } // 3,4,5 ajtó
        public int kerekekSzáma { get; set; } // 3, 4 vagy több



        public MainAuto(string ü, string m, string sz, double h, string sv, int s, int a, int k)
        {
            üzemanyag = ü;
            meghajtás = m;
            szín = sz;
            hengerÜrtertalom = h;
            sebességVáltó = sv;
            sebesség = s;
            ajtókSzáma = a;
            kerekekSzáma = k;

        }




    }


    

}
