using System;

namespace ACM.BL {
    public class ProductRepository {

        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId) {
            // Create the instance of the Product class
            // Pass in the requested ID
            Product product = new Product(productId);

            // Code that retrieves the defined product

            // Temporary hard-coded values to return
            // a populated product
            if (productId == 2) {
                product.ProductName = "Ring";
                product.ProductDescription = "One ring to rule them all";
                product.CurrentPrice = 25000m;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product) {
            var success = true;
            if (product.HasChanges) {
                if (product.IsValid) {
                    if (product.IsNew) {
                        // Call an Insert Stored Procedure
                    }
                    else {
                        // Call an Update Stored Procedure
                    }
                }
                else {
                    success = false;
                }
            }
            return success;
        }
    }
}
