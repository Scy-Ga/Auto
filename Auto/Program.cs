using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto.Classes;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            


            ClaszikusVarosiAuto auto_1 = new ClaszikusVarosiAuto("Benzin", "Hátsó", "kék", 3.5, "Autómata", 6, 5, 4, 650, "Normal", "ABS");

            Console.WriteLine($"Az autó színe: {auto_1.szín}");




            Console.ReadKey();
        }

        
    }
}
