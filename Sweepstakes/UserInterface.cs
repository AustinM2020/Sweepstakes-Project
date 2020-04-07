using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            string result = Console.ReadLine();
            return result;
        }
    }
}
