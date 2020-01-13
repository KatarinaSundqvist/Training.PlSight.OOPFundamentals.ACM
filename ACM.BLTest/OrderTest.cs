using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest {
    [TestClass]
    public class OrderTest {
        [TestMethod]
        public void ValidateValid() {
            // Arrange
            var order = new Order() {
                OrderDate = new DateTime(2019, 11, 20)
            };

            var expected = true;

            // Act
            var actual = order.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingOrderDate() {
            // Arrange
            var order = new Order();

            var expected = false;

            // Act
            var actual = order.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
