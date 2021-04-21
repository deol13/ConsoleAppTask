using System;

/// <summary>
/// Dennis Olsen
/// </summary>

namespace ConsoleAppTask
{
    //Created a generic parse to handle both int and decimal values
    static class HelpFunctions
    {
        //Goes through the array sent to the function and prints out each element in it
        public static void WritingOutArray<T>(T[] output)
        {
            char pad = ' ';
           
            foreach(T item in output)
            {
                string str = item.ToString();

                //To ensure the output looks good and is readable
                Console.Write(str.PadRight(5, pad));    
            }

            Console.WriteLine("");
        }

        public static void WriteOutAllValueBetween(int largerValue, int smallerValue)
        {
            char pad = ' ';
            //Increase by one so the smallest value isn't writen out
            smallerValue += 1;

            //Continues until the smallest value is the same as the largest value
            while (smallerValue < largerValue)
            {
                //Convert to string so we can pad it to make the output easy to read
                string output = smallerValue.ToString();
                Console.Write(output.PadRight(5, pad));

                //Increase the smallest so next value can be written out
                smallerValue++;
            }
        }
    }
}
