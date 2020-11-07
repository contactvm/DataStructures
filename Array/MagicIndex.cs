using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
       // int[] a={-2,-1,2,3,7};
        int[] a={-2,-1,2,3,7};
    
        MagicIndex m=new MagicIndex();
        m.CheckMagicIndex(a,0,a.Length-1);
        int[] b={-2,-1,0,3,7};
        m.CheckMagicIndex(b,0,b.Length-1);
        int[] c={-2,-1,0,2,4};
        m.CheckMagicIndex(c,0,c.Length-1);
    }


public class MagicIndex{
	
	public void CheckMagicIndex(int[] a,int start, int end)
	{
		if(a[(start+end)/2] ==(start+end)/2)
			Console.WriteLine(a[(start+end)/2]);
		else if(a[(start+end)/2] <(start+end)/2)
			CheckMagicIndex( a,(start+end)/2, end);
		else if(a[(start+end)/2] >(start+end)/2)
			CheckMagicIndex(a,0, (start+end)/2);
		else Console.WriteLine("-1");
	}
}
}