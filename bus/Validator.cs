using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VehicleFactoryApp.bus
{
    class Validator
    {
        public static bool IsHigher(int number1, int number2, int number3)
        {
            if (number1 > 0 && number1 <= 23 && number2 > 0 && number2 < 60 && number3 > 0 && number3 < 60)
                return true;
            else
                return false;
        }
        public static bool IsDigit(string text)
        {
            Regex pattern = new Regex(@"^([0-9]+)$");
            return pattern.IsMatch(text);
        }
        public static bool IsLetter(string text)
        {
            Regex name = new Regex(@"^([a-zA-Z]+)$");
            return name.IsMatch(text);
        }
        public static bool IsLetterDigit(string text)
        {
            Regex name = new Regex(@"^([0-9a-zA-Z]+)$");
            return name.IsMatch(text);
        }
    }
}
