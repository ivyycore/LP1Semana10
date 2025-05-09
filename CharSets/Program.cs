using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using StreamReader file = new StreamReader(args[0]);

            while (true)
            {
                string newLine = Console.ReadLine();
                if (string.IsNullOrEmpty(newLine)) {break;}
                else {file.WriteLine(newLine);}
            }
        }
    }
}