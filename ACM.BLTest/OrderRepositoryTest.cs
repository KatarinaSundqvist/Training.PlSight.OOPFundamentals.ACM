using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest {
    [TestClass]
    public class OrderRepositoryTest {
        [TestMethod]
        public void RetrieveOrderDisplayTest() {
            var orderRepository = new OrderRepository();
            var expected = new Order(10) {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            var actual = orderRepository.Retrieve(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }

        [TestMethod()]
        public void SaveTestValid() {
            // Arrange
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(10) {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 6, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                HasChanges = true
            };

            // Act
            var actual = orderRepository.Save(updatedOrder);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingOrderDate() {
            // Arrange
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(10) {
                OrderDate = null,
                HasChanges = true
            };

            // Act
            var actual = orderRepository.Save(updatedOrder);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
