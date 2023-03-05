using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibary.Tests
{
    [TestClass()]
    public class CarTests
    {
        Car car = new Car() { Id = 1, Model = "C220D", LicensePlate = "JKJ42", Price = 100000 };
        Car carNegativeId = new Car() { Id = -1, Model = "C220D", LicensePlate = "JKJ42", Price = 100000 };
        Car carModelNull = new Car() { Id = 1, Model = null, LicensePlate = "JKJ42", Price = 100000 };
        Car carModelLessThan4 = new Car() { Id = 1, Model = "C22", LicensePlate = "JKJ42", Price = 100000 };
        Car carNegativePrice = new Car() { Id = 1, Model = "C22", LicensePlate = "JKJ42", Price = -29673 };
        Car carLicensePlateNull = new Car() { Id = 1, Model = "C22", LicensePlate = null, Price = -29673 };
        Car carLicensePlateCharLessThan2 = new Car() { Id = 1, Model = "C22", LicensePlate = "I", Price = -29673 };
        Car carLicensePlateCharGreaterThan7 = new Car() { Id = 1, Model = "C22", LicensePlate = "IOFJD78KD", Price = -29673 };

        [TestMethod()]
        public void ValidateIDTest()
        {
            car.ValidateID();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carNegativeId.ValidateID());
        }

        [TestMethod()]
        public void ValidateModelTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentNullException>(() => carModelNull.ValidateModel());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carModelLessThan4.ValidateModel());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carNegativePrice.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            car.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentNullException>(() => carLicensePlateNull.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carLicensePlateCharLessThan2.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carLicensePlateCharGreaterThan7.ValidateLicensePlate());
        }
    }
}