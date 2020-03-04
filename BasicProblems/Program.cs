using System;
namespace BasicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //print reverse string
            //declaring string for reverse. 
            string sentense = "I eat";
            string reverseString = "";
            //printing reverse string
            Console.WriteLine("The input string is: {0}",sentense);
            //calling ReverseString class
            Console.WriteLine("The reverse string of the input is: {0}", ReverseString.StringReverse(sentense));
            //print "I eat" to "I tae"
            //--------------------------
            //declate the seperator
            char[] seperator = { ' ' };
            //split the sentence with space
            String[] stringList = sentense.Split(seperator);
            //calling reverse method and concatenating with 1st string 
            reverseString = stringList[0] +' '+ ReverseString.StringReverse(stringList[1]);
            //printing the reverse string
            Console.WriteLine("The reverse string of the input is: {0}", reverseString);
        }
    }
}
