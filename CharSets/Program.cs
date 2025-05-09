using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<char> cnt = new List<char>();
            foreach (string arg in args)
            {
                try
                {
                    string filecnt = cnt.ReadAllText(arg);
                    foreach (char c in filecnt);
                    {
                        
                    }

                }
            }

        }
    }
}