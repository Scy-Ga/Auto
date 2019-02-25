using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Auto.Classes
{
    class ClaszikusVarosiAuto : MainAuto
    {
        public int csomagtartóMéret { get; set; } // lieterben
        public string lámpaTípus { get; set; } //xenon, ködlámpa
        public string extrák { get; set; } //tolatóradar, üllésmagasság állítás, kanyarkövetős, sávtartás, ABS, ASR, légzsák stb.

        public ClaszikusVarosiAuto(string ü, string m, string sz, double h, string sv, int s, int a, int k, int csm, string lt, string ex ) : base(ü, m, sz, h, sv, s, a, k)
        {
            csomagtartóMéret = csm;
            lámpaTípus = lt;
            extrák = ex;

        }

        //public int Ár()
        //{

        //    if (üzemanyag == "Benzin"
        //            && meghajtás == "Első"
        //            || meghajtás == "Hátsó"
        //                && hengerÜrtertalom == 900
        //                || hengerÜrtertalom == 1000
        //                    && sebességVáltó == "Manuális"
        //                        && sebesség == 5
        //                            && ajtókSzáma == 3
        //                        || ajtókSzáma == 5)
        //        return 1690000;



        //    else if (üzemanyag == "Benzin"
        //             && meghajtás == "Hátsó"
        //                 && hengerÜrtertalom == 1000
        //                     && sebességVáltó == "Manuális"
        //                         && sebesség == 5
        //                             && ajtókSzáma == 5)
        //        return 1790000;


        //    else if (üzemanyag == "Dízel"
        //            && meghajtás == "Első"
        //            || meghajtás == "Hátsó"
        //                && hengerÜrtertalom == 2000
        //                || hengerÜrtertalom == 2500
        //                    && sebességVáltó == "Manuális"
        //                        && sebesség == 5
        //                            && ajtókSzáma == 3
        //                                || ajtókSzáma == 5)
        //        return 1750000;

        //    else if (üzemanyag == "Dízel"
        //             && meghajtás == "Hátsó"
        //                 && hengerÜrtertalom == 2500
        //                     && sebességVáltó == "Manuális"
        //                         && sebesség == 5
        //                             && ajtókSzáma == 5)
        //        return 1850000;

        //    else if (üzemanyag == "Elektromos"
        //            && meghajtás == "Első"
        //            || meghajtás == "Hátsó"
        //                && sebességVáltó == "Autómata"
        //                    && sebesség == 4
        //                        && ajtókSzáma == 3)
        //        return 3500000;

        //    else if (üzemanyag == "Elektromos"
        //             && meghajtás == "Összkerék"
        //                 && sebességVáltó == "Autómata"
        //                         && sebesség == 5
        //                             && ajtókSzáma == 5)
        //        return 4500000;


        //    else
        //    {
        //        int AlapÁr = 1500000;
        //        return AlapÁr;
        //    }   

            
        //}

    }
}
