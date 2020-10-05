using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
class Hbereken {

    public int berekening (DateTime birthday)
    {
        DateTime current = DateTime.Now;
        int age = current.Year - birthday.Year;
        if (current.Month < birthday.Month)
        {
            age--;
        }
        else
        {
            if(current.Month == birthday.Month && current.Day < birthday.Day)
            {
                age--;
            }
        }
        return age;
    }

}