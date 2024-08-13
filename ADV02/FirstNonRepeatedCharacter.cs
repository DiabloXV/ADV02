using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV02
{
    public class FirstNonRepeatedCharacter
    {
        public static int FindFirstNonRepeatedCharacter(string input)
        {
            // Dictionary to store character frequencies
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Populate the dictionary with character frequencies
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the first character with a frequency of 1
            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[input[i]] == 1)
                {
                    return i; // Return the index of the first non-repeated character
                }
            }

            return -1; // Return -1 if there is no non-repeated character
        }

       
    }
}
