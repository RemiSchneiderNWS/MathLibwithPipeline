using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;
namespace UnitTestMath
{
    [TestClass]
    public class UnitTest1
    {
        Math math = new Math();

        [TestMethod]
        public void TestAdditionMethod()
        {
            int value1 = 1;
            int value2 = 1;
            int resultExpected = value1 + value2;
            Assert.AreEqual(resultExpected, math.addition(value1, value2)) ;           

        }
        
        [TestMethod]
        public void TestMultiplicationMethod()
        {
            int value1 = 1;
            int value2 = 1;
            int resultExpected = value1 * value2;
            Assert.AreEqual(resultExpected, math.multiplication(value1, value2)) ;           

        }


        [TestMethod]
        public void TestSoustractionMethod()
        {
            int value1 = 1;
            int value2 = 1;
            int resultExpected = value1 - value2;
            Assert.AreEqual(resultExpected, math.soustraction(value1, value2));

        }


        [TestMethod]
        public void TestDivisionMethod()
        {
            int value1 = 1;
            int value2 = 1;
            int resultExpected = value1 / value2;
            Assert.AreEqual(resultExpected, math.division(value1, value2));

        }
    }
}
