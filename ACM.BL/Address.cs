namespace ACM.BL {
    public class Address {
        public Address() {
            // default constructor. If this is the only constructor you need, don't include it. It will be created by default (in the background)
            // However, if you have additional constructors, and need this default one, you must include it
            // The implicit default constructor is only created if there are no overloads
        }
        public Address(int addressId) {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        /// <summary>
        /// Validates the address data
        /// </summary>
        /// <returns></returns>
        public bool Validate() {
            var isValid = true;
            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
