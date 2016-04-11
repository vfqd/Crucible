using NUnit.Framework;
using NSubstitute;
using UnityEngine;

//Create your unit test class as outlined below. Build one unit test per logic script.
//Unit test must be stored in Assets/Engine/Unit Tests/
//To run unit tests, open Window->Editor Tests

//Code your tests to follow the Arrange-Act-Asset Pattern and try to get as much coverage 
//with tests as possible

namespace UnityTest
{
    [TestFixture]
    [Category("Example Crucible Tests")]
    internal class UnitTestExamples
    {
        //Tests go here
        [Category("Example Category")]
        [Test]
        public void SomeMethodReturnsCorrectValue()
        {
            //Arrange
            var exampleInterfaceMock = GetExampleInterfaceMock();
            var exampleLogicMock = GetExampleLogicMock();

            //Act
            exampleLogicMock.SetExampleInterface(exampleInterfaceMock);
            exampleLogicMock.SomeMethod(5f, Time.fixedDeltaTime);

            //Assert
            if (exampleLogicMock.exampleFloat == exampleLogicMock.rangeOneHundred)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }


        //Other methods go here

        //These methods make a Mock object so we can test it
        private IExampleInterface<float> GetExampleInterfaceMock()
        {
            return Substitute.For<IExampleInterface<float>>();
        }

        private ExampleLogicScript GetExampleLogicMock()
        {
            return Substitute.For<ExampleLogicScript>();
        }
    }


}
