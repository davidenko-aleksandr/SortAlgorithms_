using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] arr = new int[] { 12, 32, 5, 2};
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var iMin = i;
                for (int j = i+1; j < arr.Length ; j++)
                {
                    
                    if (arr[iMin]>arr[j])
                    {
                        iMin = j;
                    }
                }                                
                    var c = arr[iMin];
                    arr[iMin] = arr[i];
                    arr[i] = c;                       
            }
            for (int f = 0; f < arr.Length; f++)
            {
                Console.WriteLine(arr[f]);
            }
            Console.WriteLine("");
            
            
        }

    }
}
