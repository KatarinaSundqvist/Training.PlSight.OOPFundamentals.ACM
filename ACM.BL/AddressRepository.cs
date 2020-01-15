using System.Collections;
using System.Collections.Generic;

namespace ACM.BL {
    public class AddressRepository {
        /// <summary>
        /// Retrieve one address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId) {
            // Create the instance of the Address class
            // Pass in the requested ID
            Address address = new Address(addressId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated address
            if (addressId == 1) {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        /// <summary>
        /// Retrieve all addresses for one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId) {
            // Code that retrieves the defined addresses for the customer

            // Temporary hard-coded values to return a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1) {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2) {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }
        /// <summary>
        /// Saves the current address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Save(Address address) {
            var success = true;
            if (address.HasChanges) {
                if (address.IsValid) {
                    if (address.IsNew) {
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