using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "ABCDEFGH123458";
            Console.WriteLine("MyString : " + myString);
            string alphabet = String.Empty;
            string number = String.Empty;

            Match regexMatch = Regex.Match(myString, "\\d");
            if (regexMatch.Success) //Found numeric part in the coverage string
            {
                int digitStartIndex = regexMatch.Index; //Get the index where the numeric digit found
                alphabet = myString.Substring(0, digitStartIndex);
                number = myString.Substring(digitStartIndex);
            }
            Console.WriteLine("Alphabet : " + alphabet);
            Console.WriteLine("Numbers : " + number);
            Console.Read();

        }
    }
}
