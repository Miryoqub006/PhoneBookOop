using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBook.PhoneBookService.SystemService
{
    internal static class RegexPatterns
    {

        public static bool PhoneNumPattern(string input   )
        {
            
            string pattern = @"^\(\d{3}\) \d{2}-\d{3}-\d{2}-\d{2}$";

            Match match = Regex.Match(input, pattern); 
            bool isMatch = Regex.IsMatch(input, pattern); 
            return isMatch;

        }

    }
}
