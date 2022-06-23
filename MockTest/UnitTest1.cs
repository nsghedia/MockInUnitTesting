using FluentAssertions;
using MockInUnitTesting;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace MockTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCaseForImplementedMethod()
        {
            var FackRepositoryObj = new Mock<Repository>();
            Business business = new Business(FackRepositoryObj.Object);
            Assert.AreEqual(4, business.addition(2, 2));
        }
        [Test]
        public void TestCaseForNotImplementedMethod()
        {
            var FackRepositoryObj = new Mock<Repository>();
            FackRepositoryObj.Setup(self => self.substraction(3, 2)).Returns(1);
            Business business = new Business(FackRepositoryObj.Object);
            Assert.AreEqual(1, business.substraction(3, 2));
        }

        [Test]
        public void TestCaseForMethodToTest()
        {
            var list = new List<Band>();
            list.Add(
                new Band
                {
                    Name = "Neha",
                    Mobile = "9488865833",
                    Email = "nsg@gmail.com",
                    Address = "B-104"
                });
            var FackRepositoryObj = new Mock<Repository>();
            FackRepositoryObj.Setup(self => self.GetBands()).Returns(list);
            Business business = new Business(FackRepositoryObj.Object);
            business.MethodToTestBandsList();
            FackRepositoryObj.Should().NotBeNull();
        }
    }
}