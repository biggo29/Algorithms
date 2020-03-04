using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BasicProblems
{
    public class ReadFile
    {
        public static void GetSum()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Take input from file where each line contains a integer and find average");
            Console.WriteLine("------------------------------------------------------------------------");
            var list = new List<int>();
            var fileStream = new FileStream(@"E:\Biggo\other\Algorithms-Basic-Problems\BasicProblems\File\input.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    int intValue = 0;
                    if (!Int32.TryParse(line, out intValue))
                    {
                        intValue = 0;
                    }
                    list.Add(Convert.ToInt32(intValue));
                }
            }
            Console.WriteLine("Sum of the list from the file is: {0}", list.Take(list.Count).Sum());
        }
    }
}
