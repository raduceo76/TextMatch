using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextMatch.Utils
{
    public class Utility
    {
        public static char[] ToCharArray(string argument)
        {
            char[] textArray = new char[argument.Length];
            for (int i = 0; i < argument.Length; i++)
            {
                textArray[i] = argument[i];
            }
            return textArray;
        }
    }
}
