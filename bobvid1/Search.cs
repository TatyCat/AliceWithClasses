using System;
using System.Collections.Generic;
using System.Text;

namespace bobvid1
{
    class Search
    {
        
        public static string LowerInput()
        {
            //takes user input and lowers it
            Console.WriteLine("Search through Alice?");
            string searchInput = Console.ReadLine();
            searchInput = searchInput.ToLower();
            return searchInput;
        }

        public static string AliceText()
        {
            //lowers the search content - Alice in Wonderland
            string aliceInWonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            
            return aliceInWonderland.ToLower();
        }

        public static string Contains(string LowerInput, string AliceText)
        {
            if (AliceText.Contains(LowerInput))
            {
                return string.Format("Congrats! {0} was found!!!", LowerInput);
            }
            else
            {
                return "Darn, it wasn't found, try again.";
            }

        }
    }
}
