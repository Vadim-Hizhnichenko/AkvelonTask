using NUnit.Framework;
using TestAkvelon;

namespace AkvelonNUnitTests
{
    public class Tests
    {

        [Test]
        public void Test_Random_Array()
        {
            int[] array = { 2, 3, 4, 5, 6, 8, 9, 0, 10, 11 };

            int maxSecondNumber = Program.FoundMax2nd(array);
            int expectedResponse = 10;
            Assert.AreEqual(expectedResponse, maxSecondNumber);
        }
        [Test]
        public void Test_Zero_Array()
        {
            int[] array = { 0 };

            int maxSecondNumber = Program.FoundMax2nd(array);
            int expectedResponse = 0;
            Assert.AreEqual(expectedResponse, maxSecondNumber);
        }
        [Test]
        public void Test_Negative_Numbers_Array()
        {
            int[] array = { -2, -3, -5, -7, -8, -10, -3, -1, -16, -19, -20, -32, -4, -12 };
            int expectedResponse = -2;
            int maxSecondNumber = Program.FoundMax2nd(array);
            Assert.AreEqual(expectedResponse, maxSecondNumber);
        }
        [Test]
        public void Test_Large_Numbers()
        {
            int[] array = {45, 65, 87, 12, 98, 99, 34, 12, 83, 91, 55, 65, 77, 88, 23, 34};
            int maxSecondNumber = Program.FoundMax2nd(array);
            int expectedResponse = 98;
            Assert.AreEqual(expectedResponse,maxSecondNumber);
        }


    }
        
}