using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task3;
namespace task3_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_fibonachi_rec()
        {
            // arrange
            int n1 = 0;

            Program program = new Program();
            // act

            int result1 = program.Fibonachi_rec(n1);

            // assert
            Assert.AreEqual(0, result1);

            // arrange
            int n2 = 1;

            // act

            int result2 = program.Fibonachi_rec(n2);

            // assert
            Assert.AreEqual(1, result2);

            // arrange
            int n3 = 15;

            // act

            int result3 = program.Fibonachi_rec(n3);

            // assert
            Assert.AreEqual(610, result3);
        }

        public void test_fibonachi()
        {
            // arrange
            int n1 = 0;

            Program program = new Program();
            // act

            int result1 = program.Fibonachi(n1);

            // assert
            Assert.AreEqual(0, result1);

            // arrange
            int n2 = 1;

            // act

            int result2 = program.Fibonachi(n2);

            // assert
            Assert.AreEqual(1, result2);

            // arrange
            int n3 = 15;

            // act

            int result3 = program.Fibonachi(n3);

            // assert
            Assert.AreEqual(610, result3);
        }
    }
}
