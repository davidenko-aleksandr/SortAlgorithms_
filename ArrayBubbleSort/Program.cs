using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] { 78, 56, 98, 23, 1, 121 };

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
            for (int i = 0; i < Array.Length; i ++ )
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j + 1] < Array[j])
                    {
                        int chek = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = chek;

                    }
                    
                }
                
            }
            Console.WriteLine("");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"После сортировки {Array[i]}");
            }

            


        }
    }
}
