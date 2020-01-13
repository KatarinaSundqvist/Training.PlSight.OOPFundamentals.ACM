using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest {
    [TestClass]
    public class OrderItemTest {
        [TestMethod]
        public void ValidateValid() {
            // Arrange
            var orderItem = new OrderItem() {
                Product = "Ring",
                Quantity = 5,
                PurchasePrice = 25000.0m
            };

            var expected = true;

            // Act
            var actual = orderItem.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingProduct() {
            // Arrange
            var orderItem = new OrderItem() {
                Quantity = 5,
                PurchasePrice = 25000.0m
            };

            var expected = false;

            // Act
            var actual = orderItem.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingQuantity() {
            // Arrange
            var orderItem = new OrderItem() {
                Product = "Ring",
                PurchasePrice = 25000.0m
            };

            var expected = false;

            // Act
            var actual = orderItem.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingPurchasePrice() {
            // Arrange
            var orderItem = new OrderItem() {
                Product = "Ring",
                Quantity = 5,
            };

            var expected = false;

            // Act
            var actual = orderItem.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateNegativeQuantity() {
            // Arrange
            var orderItem = new OrderItem() {
                Product = "Ring",
                Quantity = -5,
                PurchasePrice = 25000.0m
            };

            var expected = false;

            // Act
            var actual = orderItem.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

