using System.Collections.Generic;
namespace Linear_DataStructures
{
    public class HashTableExercises
    {
        public static void DriverCode()
        {
            int[]a={1, 7, 5, 9, 2, 12, 3};
            int k=2;
            HashTableExercises hash= new HashTableExercises();
            hash.CountPairsWithDiff(a,k);
            
        }

        public int CountPairsWithDiff(int [] numbers, int diff)
        {
            
            int count=0;
            HashSet<int> hs= new HashSet<int>();
            foreach(int i in numbers)
            {
                if(!hs.Contains(i))
                {
                    hs.Add(i);
                }
            }

            foreach(int i in numbers)
            {
                if(hs.Contains(i-diff))
                    count++;
                if(hs.Contains(i+diff))
                    count++;
                hs.Remove(i);
            }
            
            return count;


        }
    }
}