using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        Random random = new Random();
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();

        
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, new Contestant());
            contestant.FirstName = UserInterface.GetUserInputFor("Whats your First Name?");
            contestant.LastName = UserInterface.GetUserInputFor("Whats your Last Name?");
            contestant.EmailAddress = UserInterface.GetUserInputFor("Whats your Email Address?");

        }
        public Contestant PickWinner()
        {
            int registrationNum = random.Next(1, contestants.Count);
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key == registrationNum)
                {
                    return contestant.Value;
                }
            }
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            int registrationNum = int.Parse(UserInterface.GetUserInputFor("Please Enter the Registration Number of Requested Contestant"));
            foreach (KeyValuePair<int, Contestant> info in contestants)
            {
                if (info.Key == registrationNum)
                {
                    Console.WriteLine("First Name: " + info.Value.FirstName + " Last Name: " + info.Value.LastName + " Email Address: " + info.Value.EmailAddress);
                }
            }
        }
    }
}
