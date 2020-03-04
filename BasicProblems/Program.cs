using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BasicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------
            //print reverse string
            //--------------------
            ReverseString.GetReverseString();

            //--------------------------
            //print "I eat" to "I tae"
            //--------------------------
            ReverseString.GetReverseStringLastWord();
            
            //-------------------------------------------------------------------------
            // Take input from file where each line contains a integer and find average
            //-------------------------------------------------------------------------
            ReadFile.GetSum();

        }
    }
}
