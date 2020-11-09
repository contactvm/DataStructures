//Missing Number in Array
//mistakes 
//1. Dictionary spell, access Dictionary and KeyValuePair Datatype for Iteration and access Key and Value when array
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
	
	public static void Main()
	{
		int[] a={1,2,3,2};
		
		FindDuplicateArrayFromArray(a);
	}
}

//Method 2