using System;

namespace bobvid1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Search.Contains(Search.LowerInput(), Search.AliceText()));
            Console.ReadLine();
        }
    }
}



/*ask user to search for something in the string.
 print whether or not the string was found 
 case insensitive. */