using System;
namespace StringProblems
{
    public class LongestPalindromicSubstring
    {
        public static void DriverCode()
        {
            //solution 1
            // Console.WriteLine(DisplayLongestPalindromicSubstring_on3("babad"));
            // Console.WriteLine(DisplayLongestPalindromicSubstring_on3("cbbd"));
            // Console.WriteLine(DisplayLongestPalindromicSubstring_on3("ac"));
            // string str ="civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
            // Console.WriteLine(DisplayLongestPalindromicSubstring_on3(str));

            //solution2

            Console.WriteLine(DisplayLongestPalindromicSubstring_on2("abaa"));
            Console.WriteLine(DisplayLongestPalindromicSubstring_on2("abaaba"));
        }
        public static string DisplayLongestPalindromicSubstring_on2(string str)
        {
            string maxLenthPalindrome = null;
            int maxLen = 1;
            int n = str.Length;
            int start = 0;

            int[,] table = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                table[i, i] = 1;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    table[i, i + 1] = 1;
                }
                else
                {
                     table[i, i + 1] = 2;
                }
            }

            for (int k = 3; k <= n; k++)
            {
                for (int i = 0; i <n-k+1; i++)
                {
                    int j = i + k - 1;
                    Console.WriteLine("i={0},j={1},k={2}",i,j,k);
                    if (table[i + 1, j - 1] ==1&& str[i] == str[j])
                    {

                        table[i,j]=1;
                        if (k > maxLen)
                        {
                            start = i;
                            maxLen = k;
                            maxLenthPalindrome=str.Substring(start,maxLen);
                        }
                    }
                    else
                    {
                         table[i,j]=2;
                    }
                }
            }


            return maxLenthPalindrome;
        }
        public static string DisplayLongestPalindromicSubstring_on3(string str)
        {
            string maxLenthPalindrome = null;
            int maxLen = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = str.Length - i; j > 0; j--)
                {
                    string s1 = str.Substring(i, j);

                    var s2 = ReverseString(s1);
                    if (s2.Equals(str.Substring(i, j)) && maxLen < s2.Length)
                    {
                        maxLen = s2.Length;
                        maxLenthPalindrome = s2;
                    }
                }
            }
            // Console.WriteLine(maxLen.ToString() +" "+maxLenthPalindrome);   
            return maxLenthPalindrome;
        }

        private static string ReverseString(string str)
        {
            string rstr = null;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rstr = rstr + str[i];
            }
            return rstr;
        }
    }
}