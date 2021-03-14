using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task1;

namespace test_task1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_task1()
        {

            // arrange
            int n1 = 1;

            Program program = new Program();
            // act

            bool result1 = program.test_simle_num(n1);
            
            // assert
            Assert.AreEqual(true, result1);
            
            // arrange
            int n2 = 3;

            // act

            bool result2 = program.test_simle_num(n2);

            // assert
            Assert.AreEqual(true, result2);

            // arrange
            int n3 = 4;

            // act

            bool result3 = program.test_simle_num(n3);

            // assert
            Assert.AreEqual(false, result3);

            // arrange
            int n4 = 150;

            // act

            bool result4 = program.test_simle_num(n4);

            // assert
            Assert.AreEqual(false, result4);
        }
    }
}
