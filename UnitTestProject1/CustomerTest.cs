using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluralSight_OOP;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Alex",
                LastName = "Sawyer"
            };
            string expected = "Sawyer, Alex";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    
            [TestMethod]
            public void StaticTest()
            {
        //--Arrange
            Customer customer1 = new Customer();
            customer1.FirstName = "Pedro";
            Customer.InstanceCount += 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Joseph";
            Customer.InstanceCount += 1;

            Customer customer3 = new Customer();
            customer3.FirstName = "Stuart";
            Customer.InstanceCount += 1;

        //--Act


        //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName = "John",
                EmailAddress = "john@gmail.com"
            };

            var expected = true;

            //--Act
            var actual = customer.Validate();
            
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}