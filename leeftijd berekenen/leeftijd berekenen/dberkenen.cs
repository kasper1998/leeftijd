using System;
using System.ComponentModel;

class dberkenen
{
	public int berekening(DateTime birthday)
	{
		DateTime current = DateTime.Today;
		DateTime next = new DateTime(current.Year, birthday.Month, birthday.Day);
		if (next < current)
			next = next.AddYears(1);
		int dagen = (next - current).Days;
		return dagen;
	}

}
