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
            Console.WriteLine("optie 1: je leeftijd berekenen");
            Console.WriteLine("optie 2: bereken de dagen voor je volgende verjaardag");
            return date;
        }
    }
}
