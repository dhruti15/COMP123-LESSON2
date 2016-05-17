using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_LESSON2;

namespace UnitTestForLesson2
{
    [TestClass]
    public class UnitTestForLesson2
    {
        [TestMethod]
        public void addXandYTestMethod1()
        {
            //Arrange
            int x = 40;
            int Y = 50;
            int expectedResult = 90;

            //Act
            int result = Program.addXandY(x, Y);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
