using System;

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

            while (true)
            {
                welkom.bericht();
                output.outputMessage(bereken.berekening(input.readInput()));
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

}
