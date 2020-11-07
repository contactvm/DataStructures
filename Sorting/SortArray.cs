using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[]a ={4,6,1,2,3,0,-1};
        //sort 
        for(int i=0;i<a.Length;i++)
        {
            for (int j=i+1;j<a.Length;j++)
            {
                if(a[j]<a[i])
                {
                    int tmp=a[i];
                    a[i]=a[j];
                    a[j]=tmp;
                }
        }
        }
        foreach(int t in a)
        {
            Console.WriteLine(t.ToString());
        }
        
    }
    
}
//https://stackoverflow.com/questions/3893937/sorting-an-array-in-c
// https://en.wikiversity.org/wiki/C_Source_Code/Sorting_array_in_ascending_and_descending_order
// Have a look at the following, for "advanced searches" using divide and conquer approaches:

// quicksort
// shellsort
// mergesort
// And these more straighforward algorithms for less complex ones:

// bubblesort
// selection sort
// insert sort
// Further