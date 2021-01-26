//Missing Number in Array
//mistakes 
//1. Dictionary spell, access Dictionary and KeyValuePair Datatype for Iteration and access Key and Value when array
//Missing Number in Array
using System;
using System.Collections.Generic;
public class FindDuplicateArray{
	
	public static void FindDuplicateArrayFromArray(int[] a)
	{
		
		Dictionary<int,int> _duplicatesList=new Dictionary<int,int>();

		for(int i=0;i<a.Length;i++)
		{
		   
			if(_duplicatesList.ContainsKey(a[i]))
			{
				_duplicatesList[a[i]]=_duplicatesList[a[i]]+1;
			}
			else
			{
				_duplicatesList.Add(a[i],1);
			}
		}
		
		foreach(KeyValuePair<int,int> keyValue in _duplicatesList)
		{
		    
			if(keyValue.Value>1)
			{
				Console.WriteLine("i="+keyValue.Key.ToString()+" j:" +keyValue.Value.ToString());
			}
		}
	}
// https://www.geeksforgeeks.org/duplicates-array-using-o1-extra-space-set-2/?ref=rp
	
// Traverse the given array from start to end.
// For every element in the array increment the arr[i]%n‘th element by n.
// Now traverse the array again and print all those indices i for which arr[i]/n is greater than 1. Which guarantees that the number n has been added to that index.
// Note: This approach works because all elements are in the range from 0 to n-1 and arr[i]/n would be greater than 1 only if a value “i” has appeared more than once. 
	static void printRepeating(int[] arr, int n)
    {
        // First check all the values that are
        // present in an array then go to that
        // values as indexes and increment by
        // the size of array
        for (int i = 0; i < n; i++) 
        {
            int index = arr[i] % n;
            //Console.WriteLine("index="+index.ToString()+"  arr[i]"+ arr[i].ToString());
            arr[index] += n;
        }
        foreach(var i in arr)
        {
            Console.WriteLine(i.ToString());
        }
 
        // Now check which value exists more
        // than once by dividing with the size
        // of array
        for (int i = 0; i < n; i++)
        {
            int t=(arr[i] / n);
            //Console.WriteLine(t.ToString());
            if ((arr[i] / n) >= 2)
                {
                    Console.Write(i + " ");
                }
        }
    }
	
	public static void Main()
	{
		int[] a={1,2,3,2};
		int[] b={1,3,2,3,4};
		FindDuplicateArrayFromArray(a);
		printRepeating(b,b.Length);
	}
}
// Complexity Analysis: 

// Time Complexity: O(n). 
// Only two traversal is needed. So the time complexity is O(n)
// Auxiliary Space: O(1). 
// As no extra space is needed, so the space complexity is constant