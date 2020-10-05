using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;  

namespace leeftijd_berekenen
{
    class Output
    {
        public void outputMessage(int age)
        {
            Console.Clear();
            Console.WriteLine("Uw leeftijd is " + age + " jaar.");
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
