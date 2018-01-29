using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Player;

namespace PlayerTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void TestGreetPlayer()
        {
            //Arrange
            string ExpectedGreeting = "Hello Zach";
            Person Player1 = new Person("Zach");

            //Act
            string Greeting = Player1.GreetPerson();

            //Assert
            Assert.AreEqual(ExpectedGreeting, Greeting);

        }
    }
}

