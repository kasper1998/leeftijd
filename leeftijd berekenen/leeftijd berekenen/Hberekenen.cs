using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
class Hbereken {

public berekening (DateTime birthday)
{
DateTime current = DateTime.Now();
int age = current.Year - birthday.Year;
return age;
}

}