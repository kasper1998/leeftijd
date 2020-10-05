using System;
using System.Collections.Generic;
using System.Text;

namespace leeftijd_berekenen
{
    class BirthdayChecker
    {
        public bool birthdayCheck(DateTime birthday)
        {
            if ((birthday.Day - DateTime.Now.Day) == 0 && (birthday.Month - DateTime.Now.Month) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
