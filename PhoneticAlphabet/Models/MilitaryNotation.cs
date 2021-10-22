using System;
using System.Collections.Generic;

namespace PhoneticAlphabet.Models
{
    public class MilitaryNotation
    {
        private Dictionary<char, string> abc;

        public MilitaryNotation()
        {
            abc = new Dictionary<char, string>
            {
                { 'a', "Alfa" },
                { 'b', "Bravo" },
                { 'c', "Charlie" },
                { 'd', "Delta" },
                { 'e', "Echo" },
                { 'f', "Foxtrot" },
                { 'g', "Golf" },
                { 'h', "Hotel" },
                { 'i', "India" },
                { 'j', "Juliet" },
                { 'k', "Kilo" },
                { 'l', "Lima" },
                { 'm', "Mike" },
                { 'n', "November" },
                { 'o', "Oscar" },
                { 'p', "Papa" },
                { 'q', "Quebec" },
                { 'r', "Romeo" },
                { 's', "Sierra" },
                { 't', "Tango" },
                { 'u', "Uniform" },
                { 'v', "Victor" },
                { 'w', "Whiskey" },
                { 'x', "X-ray" },
                { 'y', "Yankee" },
                { 'z', "Zulu" },
            };
            
        }

        public List<string> Get(string word)
        {
            List<string> result = new List<string>();
            if (!string.IsNullOrEmpty(word))
            {
                foreach (var c in word.ToLower())
                    result.Add(abc.GetValueOrDefault(c, string.Empty) + " for " + c.ToString().ToUpper());
                return result;
            }
            else
                return null;
        }
    }
}
