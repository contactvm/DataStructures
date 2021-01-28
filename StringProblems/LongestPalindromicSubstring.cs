using System;
namespace StringProblems
{
    public class LongestPalindromicSubstring
    {
        public static void DriverCode()
        {
            Console.WriteLine(DisplayLongestPalindromicSubstring_on2("babad"));
            Console.WriteLine(DisplayLongestPalindromicSubstring_on2("cbbd"));
            Console.WriteLine(DisplayLongestPalindromicSubstring_on2("ac"));
            string str ="civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
            Console.WriteLine(DisplayLongestPalindromicSubstring_on2(str));
        } 

        public static string DisplayLongestPalindromicSubstring_on2(string str)
        {
             string maxLenthPalindrome=null;
             int maxLen=0;
             for(int i=0;i<str.Length;i++)
             {
                 for(int j=str.Length-i;j>0;j--)
                 {
                    string s1=str.Substring(i,j);
                     
                    var s2= ReverseString(s1);
                    if(s2.Equals(str.Substring(i,j)) &&maxLen<s2.Length)
                    {
                        maxLen=s2.Length;
                        maxLenthPalindrome=s2;
                    }
                 }
             }
            // Console.WriteLine(maxLen.ToString() +" "+maxLenthPalindrome);   
            return maxLenthPalindrome  ;
        }

        private  static string ReverseString(string str)
        {
            string rstr=null;

            for(int i=str.Length-1;i>=0;i--)
            {
                rstr=rstr+str[i];
            }
            return rstr;
        }
    }
}