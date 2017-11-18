using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cap._3_List3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(ValidateZipCode(Console.ReadLine()));
                Console.WriteLine(ValidateZipCodeREgeEx(Console.ReadLine()));

                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex(@"[ ]{2,}", options);

                string input = "1 2 3 4  5";
                string result = regex.Replace(input, " ");

                Console.WriteLine(result);
            }
        }

        static bool ValidateZipCode(string zipCode)
        {
            if (zipCode.Length < 6) return false;

            string numberPart = zipCode.Substring(0, 4);
            int number;
            if (!int.TryParse(numberPart, out number)) return false;

            string characterPart = zipCode.Substring(4);

            if (numberPart.StartsWith("0")) return false;
            if (characterPart.Trim().Length < 2) return false;
            if (characterPart.Length == 3 && characterPart.Trim().Length != 2) return false;

            return true;
        }

        static bool ValidateZipCodeREgeEx(string zipcode)
        {
            Match match = Regex.Match(zipcode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);

            return match.Success;
        }
    }
}
