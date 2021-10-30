using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularGenTools.Utils
{
    public static class ValidateString
    {
        public static bool IsNullOrBlank(string input)
        {
            
            if(input=="" || input == null)
            {
                return true;
            }
            return false;
        }

    }
}
