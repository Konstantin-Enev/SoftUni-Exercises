using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359(?<so>\s||-)2\k<so>[0-9]{3}\k<so>[0-9]{4}\b";

            string phones = Console.ReadLine();

            MatchCollection phoneNumbers = Regex.Matches(phones, regex);

            string[] matchedPhones = phoneNumbers.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
