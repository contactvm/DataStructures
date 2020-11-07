//Missing Number in Array
//Method 1- get total sum of array - n*(n+1)/2 o(n)
//1,2,3,5
//15 = (4+1)(4+2)/2=15

//14 first iteration
//12 second
//9 third
//4 forth

using System;

public class MissingNumber
{
	public static int GetMissingNumberFromArray(int[] a, int n)
	{
		int total=0;
		total=(n+1)*(n+2)/2;
		Console.WriteLine(total.ToString());
		for(int i=0; i<n;i++)
		{
			total=total-a[i];
			Console.WriteLine(total.ToString());
			
		}
		return total;
	}
	
	public static void Main()
	{
		int[] a={1,2,3,5};
		int _MissingNumber=GetMissingNumberFromArray(a,a.Length);
		Console.WriteLine(_MissingNumber.ToString());
	}
}

