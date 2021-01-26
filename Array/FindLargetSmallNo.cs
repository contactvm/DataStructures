using System;

public class FindLargetSmallNo
{
	public static void Main()
	{
		int[] a={1,3,4,2,-10};
		int small=a[0];
		int large=a[0];
		
		for(int i=1;i<a.Length;i++)
		{
			if(a[i]>large)
				large=a[i];
			if(a[i]<small)
				small=a[i];
		}
		
		Console.WriteLine(large.ToString()+" "+ small.ToString());
	}
}