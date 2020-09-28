using System;
using System.Collections.Generic;
using System.Text;

namespace leeftijd_berekenen
{
    class Input
    {
        public string[] readInput()
        {
            string input = Console.ReadLine();
            string[] date = input.Split('/');
            return date;
        }
    }
}
