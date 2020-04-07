using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesFactory
    {
        public ISweepstakesManager ChooseSweepstakesManager(string input)
        {
            switch (input)
            {
                case "Queue":
                    return new SweepstakesQueueManager();
                case "Stack":
                    return new SweepstakesStackManager();
                default:
                    Console.WriteLine("Invalid input please type in either Queue or Stack.");
                    return ChooseSweepstakesManager(UserInterface.GetUserInputFor("Would you like a Queue or a Stack to manage your Sweepstakes?"));
            }
        }
    }
}
