using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest {
    [TestClass]
    public class ProductTest {
        [TestMethod]
        public void ValidateValid() {
            // Arrange
            var product = new Product() {
                ProductName = "Ring",
                CurrentPrice = 25000.0m
            };

            var expected = true;

            // Act
            var actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingProductName() {
            // Arrange
            var product = new Product() {
                CurrentPrice = 25000.0m
            };

            var expected = false;

            // Act
            var actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingCurrentPrice() {
            // Arrange
            var product = new Product() {
                ProductName = "Ring"
            };

            var expected = false;

            // Act
            var actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
