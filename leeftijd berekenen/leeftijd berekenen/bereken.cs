using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace leeftijd_berekenen
{
    class bereken
    {
        Hbereken hberkeneken = new Hbereken();
        dberkenen dberekenen = new dberkenen();
        BirthdayChecker birthdayChecker = new BirthdayChecker();
        public int keuze(int i, DateTime input)
        {
            switch (i)
            {
                case 1:
                    return hberkeneken.berekening(input);
                case 2:
                    return dberekenen.berekening(input);
                default:
                    return 0;

            }
        }
    }
}
