using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProblems
{
    public class ReverseString
    {
        public static void GetReverseString()
        {
            //declaring string for reverse.
            Console.WriteLine("--------------------");
            Console.WriteLine("print reverse string");
            Console.WriteLine("--------------------");
            string sentense = "I eat";
            string reverseString = "";
            //printing reverse string
            Console.WriteLine("The input string is: {0}", sentense);
            //calling ReverseString class
            Console.WriteLine("The reverse string of the input is: {0}", ReverseString.StringReverse(sentense));
        }

        public static void GetReverseStringLastWord()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("print 'I eat' to 'I tae'");
            Console.WriteLine("------------------------");
            //declaring string for reverse. 
            string sentense = "I eat";
            string reverseString = "";
            //declate the seperator
            char[] seperator = { ' ' };
            //split the sentence with space
            String[] stringList = sentense.Split(seperator);
            //calling reverse method and concatenating with 1st string 
            reverseString = stringList[0] + ' ' + ReverseString.StringReverse(stringList[1]);
            //printing the reverse string
            Console.WriteLine("The reverse string(Last word) of the input is: {0}", reverseString);
        }
        public static string StringReverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
