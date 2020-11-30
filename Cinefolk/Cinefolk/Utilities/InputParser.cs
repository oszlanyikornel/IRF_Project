using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinefolk.Utilities
{
    static class InputParser
    {
        public static string modifyYear(string year)
        {
            if (year == "" || year == "Year...")
            {
                return "";
            } else
            {
                return year;
            }
            
        }
    }
}
