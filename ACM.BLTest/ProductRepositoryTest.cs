using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest {
    [TestClass]
    public class ProductRepositoryTest {
        [TestMethod]
        public void RetrieveTest() {
            var productRepository = new ProductRepository();
            var expected = new Product(2) {
                CurrentPrice = 25000m,
                ProductName = "Ring",
                ProductDescription = "One ring to rule them all"
            };

            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}
