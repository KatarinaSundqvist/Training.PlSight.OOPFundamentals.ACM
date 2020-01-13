using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL {
    public class Order {
        public Order() {

        }
        public Order(int orderId) {
            OrderId = OrderId;
        }
        
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId) {
            // Code that retrieves the defined order
            return new Order();
        }

        /// <summary>
        /// Retrieve all orders
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve() {
            // Code that retrieves all of the orders
            return new List<Order>();
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save() {
            // Code that saves the defined order
            return true;
        }

        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public bool Validate() {
            var isValid = true;

            if (OrderDate==null) isValid = false;

            return isValid;
        }
    }
}
