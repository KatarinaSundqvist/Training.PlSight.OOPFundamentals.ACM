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

        public bool Validate() {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}