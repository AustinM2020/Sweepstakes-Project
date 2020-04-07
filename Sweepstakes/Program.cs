using System;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.CreateMarketingFirmManager(new SweepstakesFactory());
            Console.ReadLine();
        }
    }
}
