using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextMatch.Utils;

namespace TextMatch.Service
{
    public interface IStringMatchService
    {
        string FindMatchText(string text, string subtext);
    }

    public class StringMatchService : IStringMatchService
    {
        public string FindMatchText(string inText, string inSubtext)
        {
            char[] text = Utility.ToCharArray(inText);
            char[] subtext = Utility.ToCharArray(inSubtext);
            int position = 0;
            int firstIndex = 0;
            int index = 0;
            bool foundFirst = false;
            bool done = false;
            string separator = string.Empty;
            string stringOut = string.Empty;

            while (!done)
            {
                if (Char.ToLower(text[index]) == Char.ToLower(subtext[position]))
                {
                    if (!foundFirst)
                    {
                        firstIndex = index;
                        foundFirst = true;
                    }
                    position++;
                    index++;

                    if (position == subtext.Length)
                    {
                        stringOut += separator;
                        stringOut += firstIndex + 1;
                        separator = ",";

                        position = 0;
                        index = firstIndex + 1;
                        foundFirst = false;
                    }
                }
                else
                {
                    index++;
                    position = 0;
                    foundFirst = false;
                }
                if (text.Length == index)
                {
                    done = true;
                }
            }

            return stringOut;
        }
    }
}
