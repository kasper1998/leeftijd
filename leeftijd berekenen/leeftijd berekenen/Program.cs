﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace leeftijd_berekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            welcom welkom = new welcom();
            Output output = new Output();
            Input input = new Input();
            Hbereken bereken = new Hbereken();
            dberkenen dagenberekenen = new dberkenen();
            BirthdayChecker birthdayChecker = new BirthdayChecker();
            DateTime birthday;

            while (true)
            {
                welkom.bericht();
                birthday = input.readInput();
                output.outputMessage(bereken.berekening(birthday));
                output.birthDayMessage(birthdayChecker.birthdayCheck(birthday));
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

}
