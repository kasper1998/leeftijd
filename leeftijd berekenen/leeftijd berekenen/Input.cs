using System;
using System.Collections.Generic;
using System.Text;

namespace leeftijd_berekenen
{
    class Input
    {
        public DateTime readInput()
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.Parse(input);
            return date;
        }
    }
}
