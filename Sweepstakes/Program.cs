using System;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("king");
            sweepstakes.RegisterContestant();
        }
    }
}
