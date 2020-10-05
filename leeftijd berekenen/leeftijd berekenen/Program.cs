using System;
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

            while (true)
            {
                welkom.bericht();
                string antwoord = Console.ReadLine();
                if(antwoord == "leefijd") { output.outputMessage(bereken.berekening(input.readInput()),1); }
                if(antwoord == "dagen") { output.outputMessage(dagenberekenen.berekening(input.readInput()), 2); }
                

                Console.ReadKey();
                Console.Clear();
            }
        }
    }

}
