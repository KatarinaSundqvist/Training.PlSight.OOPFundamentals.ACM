using System.Collections.Generic;

namespace ACM.BL {
    public class Customer {

        public Customer() {
            // default constructor. If this is the only constructor you need, don't include it. It will be created by default (in the background)
            // However, if you have additional constructors, and need this default one, you must include it
            // The implicit default constructor is only created if there are no overloads
        }

        public Customer(int customerId) {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)) {
                    if (!string.IsNullOrWhiteSpace(fullName)) {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName {
            get {
                return _lastName;
            }
            set {
                _lastName = value;
            }
        }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId) {
            // Code that retrieves the defined customer
            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve() {
            // Code that retrieves all of the customers
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save() {
            // Code that saves the defined customer
            return true;
        }

        /// <summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate() {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}