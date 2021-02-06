// https://www.geeksforgeeks.org/given-a-string-find-its-first-non-repeating-character/
// https://www.programcreek.com/2012/11/top-10-algorithms-for-coding-interview/
// https://jsonmock.hackerrank.com/api/countries/search?s=%22u%22n&p=100090
namespace StringProblems
{
// Time Complexity: O(n).
// As the string need to be traversed at-least once.
// Auxiliary Space: O(n).
// The space is occupied by the use of count_array/hash_map to keep track of frequency.
    public class FirstUniqueCharacterString
    {

        public static int GetFirstUniqueCharacterString(string input)
        {

            int NoOfChar = 256;
            int[] count = new int[NoOfChar];
            int index = -1;
            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    count[input[i]] += 1;
                }
              
                for (int i = 0; i < input.Length; i++)
                {
                    if (count[input[i]] == 1)
                    {
                        System.Console.WriteLine(input[i]);
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }

        public static void DriverCode()
        {
            int index = GetFirstUniqueCharacterString("vviiiraj");
            if (index == -1)
            {
                System.Console.WriteLine("no unique character");
            }
            else
            {
                System.Console.WriteLine("index of first unique character" + index);
            }

            index = GetFirstUniqueCharacterString(null);
            if (index == -1)
            {
                System.Console.WriteLine("no unique character");
            }
            else
            {
                System.Console.WriteLine("index of first unique character" + index);
            }

        }
    }
}