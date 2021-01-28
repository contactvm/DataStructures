using System;
namespace StringProblems
{//O(n)
    public class PrintDuplicatesCharacters{

        public static void DisplayDuplicatesCharactersCount(string str)
        {
            int NoOfChar=256;
            int[] count=new int[NoOfChar];
            FillCharsCount(str,count);
            for(int i=0;i<NoOfChar;i++)
            {
                if(count[i]>1)
                {
                    char chr=Convert.ToChar(i);
                    Console.WriteLine("Char [" +  chr+"] count "+count[i].ToString());
                }
            }
        }

        private static void FillCharsCount(string str, int [] count)
        {
            for(int i=0;i<str.Length;i++)
            {
                count[str[i]]+=1;
            }
        }

        public static void DriverCode()
        {
            DisplayDuplicatesCharactersCount("test");
            DisplayDuplicatesCharactersCount("bbbbb");
            DisplayDuplicatesCharactersCount("abababab");
            DisplayDuplicatesCharactersCount("");
            DisplayDuplicatesCharactersCount("__$$//");
            DisplayDuplicatesCharactersCount("  test  ");
        }
    }
}