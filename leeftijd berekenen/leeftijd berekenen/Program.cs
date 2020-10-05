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
            bereken calculator = new bereken();
            DateTime birthday;

            while (true)
            {
                welkom.bericht();
                birthday = input.readInput();
                int keuze = Convert.ToInt32(Console.ReadLine());
                output.outputMessage(calculator.keuze(keuze,birthday));
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

}
