using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubbleSort<int>();
            
            
                var rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    bubble.Items.Add(rnd.Next(0, 100));
                }
            


            bubble.Sort();
        }
    }
}