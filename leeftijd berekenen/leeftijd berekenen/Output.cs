using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;  

namespace leeftijd_berekenen
{
    class Output
    {
        public void outputMessage(int age,int keuze)
        {
            Console.Clear();
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("Uw leeftijd is " + age + " jaar.");
                    break;
                case 2:
                    Console.WriteLine("" + age + " dagen voor je volgende varjaardag.");

                    break;
            }
            Console.WriteLine();
        }

        public void birthDayMessage(bool birthday)
        {
            if (birthday)
            {
                Console.WriteLine("Gelukkige verjaardag!");
            }
        }
    }
}
