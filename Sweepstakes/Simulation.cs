using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmManager(SweepstakesFactory factory)
        {
            MarketingFirm marketingFirm = new MarketingFirm(factory.ChooseSweepstakesManager(UserInterface.GetUserInputFor("Would you like a Queue or a Stack to manage your Sweepstakes?")));
        }
    }
}
