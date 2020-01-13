using System.Collections.Generic;

namespace ACM.BL {
    public class Product {
        public Product() {

        }
        public Product(int productId) {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId) {
            // Code that retrieves the defined product
            return new Product();
        }

        /// <summary>
        /// Retrieve all products
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve() {
            // Code that retrieves all of the products
            return new List<Product>();
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save() {
            // Code that saves the defined product
            return true;
        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public bool Validate() {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
