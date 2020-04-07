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
            contestant.RegistrationNumber = contestants.Count;
            contestant.FirstName = UserInterface.GetUserInputFor("Whats your First Name?");
            contestant.LastName = UserInterface.GetUserInputFor("Whats your Last Name?");
            contestant.EmailAddress = UserInterface.GetUserInputFor("Whats your Email Address?");
            contestants.Add(contestant.RegistrationNumber, contestant);
            Console.Clear();
        }
        public Contestant PickWinner()
        {
            int num = random.Next(0, (contestants.Count - 1));
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(contestants.Count == 0)
                {
                    Console.WriteLine("There are no registered contestants.");
                }
                else if(contestant.Key == num)
                {
                    return contestant.Value;
                }
            }
            return PickWinner();
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Registration Number: " + contestant.RegistrationNumber + " First Name: " + contestant.FirstName + " Last Name: " + contestant.LastName + " Email Address: " + contestant.EmailAddress);
        }
        public void NotifyContestants(Contestant contestant)
        {
            foreach(KeyValuePair<int, Contestant> entry in contestants) 
            {
                if (entry.Key == contestant.RegistrationNumber)
                {
                    contestant.Notify("Congrats " + entry.Value.FirstName + " " + entry.Value.LastName + " You've Won The " + name + " Sweepstakes");
                }
                else
                {
                    contestant.Notify("Sorry " + entry.Value.FirstName + " " + entry.Value.LastName + " You Didn't Win The " + name + " Sweepstakes");
                }
            }
        }
    }
}
