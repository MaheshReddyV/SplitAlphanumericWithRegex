# SplitAlphanumericWithRegex
Split Alpha numeric into Alphabet and Number using Regex and C#
 string myString = "ABCDEFGH123458";
            string alphabet = String.Empty;
            string number = String.Empty;

            Match regexMatch = Regex.Match(myString, "\\d");
            if (regexMatch.Success) //Found numeric part in the coverage string
            {
                int digitStartIndex = regexMatch.Index; //Get the index where the numeric digit found
                alphabet = myString.Substring(0, digitStartIndex);
                number = myString.Substring(digitStartIndex);
            }
