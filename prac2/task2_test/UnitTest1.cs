using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            Program program = new Program();

            int[] test_arr = new int[10];

            test_arr[0] = 2;

            test_arr[1] = 4;

            test_arr[2] = 6;

            test_arr[3] = 8;

            test_arr[4] = 10;

            test_arr[5] = 15;

            test_arr[6] = 45;

            test_arr[7] = 53;

            test_arr[8] = 87;

            test_arr[9] = 99;

            int find_index = program.BinarySearch(test_arr, 15);

            Assert.AreEqual(5, find_index);

            find_index = program.BinarySearch(test_arr, 2);

            Assert.AreEqual(0, find_index);

            find_index = program.BinarySearch(test_arr, 99);

            Assert.AreEqual(9, find_index);
        }
    }
}
