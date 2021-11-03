  /********************   Assignment-> 1   *******************/
 /* Q=>How to reverse the order of words in a given string? */
/***********************************************************/

using System;

namespace Rverse_The_Words_In_Given_String
{
    class ReverseString
    {

        public static void RevString(string Str1)
        {
            int Length, i;
            int Temp_End, Temp_Start;

            Length = Str1.Length;    //Count Length Of Given String

            i = 0;
            while (Length > i)
            {
                while (Length != 0 && Str1[Length - 1] == ' ')
                {
                    Console.Write(" ");
                    Length--;
                }   //end while

                Temp_End = Length - 1;

                while (Length != 0 && Str1[Length - 1] != ' ')
                {
                    Length--;
                }   //end while
                Temp_Start = Length;

                while (Temp_Start <= Temp_End)
                {
                    Console.Write(Str1[Temp_Start]);
                    Temp_Start++;
                }   //end while

            }   //end while
        }   //end RevString-Method


        static void Main(string[] args)
        {
            string Str = null;

            Console.Write("Please Enter A String => ");
            Str = Console.ReadLine();   //Taking String From User

            RevString(Str);

            Console.ReadLine();
        }   //end Main-Method

    }   //end class

}   //end namespace
