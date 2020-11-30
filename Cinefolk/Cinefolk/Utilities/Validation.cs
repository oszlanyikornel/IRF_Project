using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinefolk.Utilities
{
    static class Validation
    {
        public static bool isYear(string year)
        {
            int parsedYearInput;
            bool isNumeric = int.TryParse(year, out parsedYearInput);

            if (isNumeric)
            {
                if (parsedYearInput > 1900 && parsedYearInput < 2100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
