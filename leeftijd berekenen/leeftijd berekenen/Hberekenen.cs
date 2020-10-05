using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
class Hbereken {

    public int berekening (DateTime birthday)
    {
        DateTime current = DateTime.Now;
        int age = (current - birthday).Days / 365;
        return age;
    }

}