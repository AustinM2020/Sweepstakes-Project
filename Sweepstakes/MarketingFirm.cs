using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("What is the Name of your Sweepstakes?"));
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}
