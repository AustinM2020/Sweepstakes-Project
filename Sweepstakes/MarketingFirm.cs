using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public void CreateSweepstakes(ISweepstakesManager manager)
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("What is the Name of your Sweepstakes"));
        }
    }
}
