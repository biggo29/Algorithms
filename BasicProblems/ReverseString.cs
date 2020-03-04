using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProblems
{
    public class ReverseString
    {
        public static string StringReverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
