using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Contestant
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        public Contestant()
        {
            
        }
        public void Notify(string input)
        {
            Console.WriteLine(input);
        }
    }
}
