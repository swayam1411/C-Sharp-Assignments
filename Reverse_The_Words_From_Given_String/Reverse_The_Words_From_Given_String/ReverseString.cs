  /********************   Assignment-> 1   *******************/
 /* Q=>How to reverse the order of words in a given string? */
/***********************************************************/

using System;

namespace Rverse_The_Words_From_Given_String
{
    public class ReverseString
    { 
        static void Main(string[] args)
        {
            Console.Write("Input String => ");
            string input = Console.ReadLine();   //Taking String From User

            string[] split = input.Split(' ');  //separate words from string and store in spilt array

            Array.Reverse(split);   //Reverse Order of elements in split array

            Console.Write("Output String=> ");
            foreach (string printword in split)
            {
                Console.Write(printword + " ");
            }

            Console.ReadLine();
        }   //end Main-Method

    }   //end class

}   //end namespace
