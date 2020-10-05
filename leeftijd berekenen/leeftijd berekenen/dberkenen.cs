using System;
using System.ComponentModel;

class dberkenen
{
	public int Dberekening(DateTime birthday)
	{
		DateTime current = DateTime.Today;
		DateTime next = new DateTime(birthday.Day, birthday.Month, current.Year);
		if (current < current)
			next = next.AddYears(1);
		int dagen = (next - current).Days;
		return dagen;
	}

}
