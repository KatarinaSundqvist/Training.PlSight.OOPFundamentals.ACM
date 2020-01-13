using System.Collections.Generic;

namespace ACM.BL {
    public class OrderItem {
        public OrderItem() {

        }
        public OrderItem(int orderItemId) {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieve one order item
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId) {
            // Code that retrieves the defined order item
            return new OrderItem();
        }

        /// <summary>
        /// Retrieve all order items
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve() {
            // Code that retrieves all of the order items
            return new List<OrderItem>();
        }

        /// <summary>
        /// Saves the current order item
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

            if (string.IsNullOrEmpty(Product)) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
