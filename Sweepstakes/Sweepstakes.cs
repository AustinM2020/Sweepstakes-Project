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
            contestant.RegistrationNumber = int.Parse(UserInterface.GetUserInputFor("What is your Registration Number?"));
            contestant.FirstName = UserInterface.GetUserInputFor("Whats your First Name?");
            contestant.LastName = UserInterface.GetUserInputFor("Whats your Last Name?");
            contestant.EmailAddress = UserInterface.GetUserInputFor("Whats your Email Address?");
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            int index = random.Next(0, (contestants.Count - 1));
            return contestants[index];
          
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Registration Number: " + contestant.RegistrationNumber + " First Name: " + contestant.FirstName + " Last Name: " + contestant.LastName + " Email Address: " + contestant.EmailAddress);
        }
    }
}
