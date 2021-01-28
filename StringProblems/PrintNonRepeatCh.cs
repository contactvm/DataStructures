using System;
using System.Collections.Generic;
namespace StringProblems
{
    public class PrintNonRepeatCh
    {
        public static string GetMaxLnPrintNonRepeatCh(string input)
        {
            int i;    
            int n = input.Length;
            int st = 0;
            int currentLen = 0;

            int maxLen = 0;
            int start = 0;

            Dictionary<char, int> pos = new Dictionary<char, int>();
            if (n > 0)
            {
                pos.Add(input[0], 0);
                for ( i = 1; i < n; i++)
                {
                    if (!pos.ContainsKey(input[i]))
                    {
                        pos.Add(input[i], i);
                    }
                    else
                    {
                        if (pos[input[i]] >= st)
                        {
                            currentLen = i - st;
                            if (maxLen < currentLen)
                            {
                                maxLen = currentLen;
                                start = st;
                            }
                            st = pos[input[i]] + 1;
                        }

                        pos[input[i]] = i;
                    }
                    
                }
                if (maxLen < i - st)
                    {
                        maxLen = i - st;
                        start = st;
                    }
                
                return input.Substring(start, maxLen);
            }
            else
                return input;

        }
        public static void DriverCode()
        {
            //example with edge cases
            Console.WriteLine(GetMaxLnPrintNonRepeatCh("abcabcab"));
            Console.WriteLine(GetMaxLnPrintNonRepeatCh("bbbbb"));
            Console.WriteLine(GetMaxLnPrintNonRepeatCh("pwwkew"));
            Console.WriteLine(GetMaxLnPrintNonRepeatCh(""));
            Console.WriteLine(GetMaxLnPrintNonRepeatCh("au"));
            Console.WriteLine(GetMaxLnPrintNonRepeatCh(" "));
        }
    }
}