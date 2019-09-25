using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentSENG8040_1;
using NUnit.Framework;

namespace TestCases
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetRecLength_Input1return1()
            {
                //Arrange
                int RecLength = 1;
                int RecWidth = 2;
                // double expectedResult = RecWidth;
                Rectangle rectTest = new Rectangle(RecLength, RecWidth);
                //Act 
                double actualResult = rectTest.GetRecLength();
                //Assert 
                Assert.AreEqual(RecLength, actualResult);
            }
            [Test]
            public void GetRecWidth_Input3return3()
            {
                //Arrange
                int RecLength = 1;
                int RecWidth = 3;
                // double expectedResult = RecWidth;
                Rectangle rectTest = new Rectangle(RecLength, RecWidth);
                //Act 
                double actualResult = rectTest.GetRecWidth();
                //Assert 
                Assert.AreEqual(RecWidth, actualResult);
            }
            [Test]
            public void SetRecLength_Input3return1()
            {
                //Arrange
                int RecLength = 3;
                int RecWidth = 2;
                // double expectedResult = RecWidth;
                Rectangle rectTest = new Rectangle(RecLength, RecWidth);
                //Act 
                double actualResult = rectTest.SetRecLength(RecLength);
                //Assert 
                Assert.AreEqual(RecLength, actualResult);
            }
            [Test]
            public void SetRecWidth_Input7return7()
            {
                //Arrange
                int RecLength = 7;
                int RecWidth = 2;
               // double expectedResult = RecWidth;
                Rectangle rectTest = new Rectangle(RecLength, RecWidth);
                //Act 
                double actualResult = rectTest.SetRecWidth(RecWidth);
                //Assert 
                Assert.AreEqual(RecWidth, actualResult);
            }
            [Test]
            public void GetPerimeterinput2and2returns8()
            {
                //Arrange
                int RecLength = 2;
                int RecWidth = 2;
                int total=((2*RecLength)+ (2*RecWidth));
                // double expectedResult = RecWidth;
                Rectangle rectTest = new Rectangle(RecLength, RecWidth);
                //Act 
                double actualResult = rectTest.GetPerimeter();
                //Assert 
                Assert.AreEqual(total, actualResult);
            }
            [Test]
            public void GetAreainput2and3returns6()
            {
                //Arrange
                int RecLength = 2;
                int RecWidth = 3;
                int total = (RecLength * RecWidth);
                // double expectedResult = RecWidth;
                Rectangle rectTest = new Rectangle(RecLength, RecWidth);
                //Act 
                double actualResult = rectTest.GetArea();
                //Assert 
                Assert.AreEqual(total, actualResult);
            }


        }
    }
}
