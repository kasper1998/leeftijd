using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
