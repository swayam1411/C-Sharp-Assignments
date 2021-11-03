  /********************   Assignment-> 1   *******************/
 /* Q=>How to reverse the order of words in a given string? */
/***********************************************************/

using System;

namespace Reverse_Words_From_Given_String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String => ");
            string inputstring = Console.ReadLine();    //Taking String as input from user.

            string[] split = inputstring.Split();  //separate words from string & stores in array.

            Array.Reverse(split);   //Reverse Elements is Array spilt.

            Console.Write("Output String=> ");
            foreach (string printwords in split)
            {
                Console.Write(printwords + " ");
            }   //end foreach
            Console.ReadLine();
        }   //end Main
    }   //end class
}   //end namespace
