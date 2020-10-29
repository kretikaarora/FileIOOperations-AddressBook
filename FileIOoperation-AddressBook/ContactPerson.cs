// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactPerson.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
//
namespace AddressBookSystem
{/// <summary>
/// Declares variables required in AddressBook
/// </summary>
    public class ContactPerson
    {
        public string firstName { get; set;}
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public double phoneNo { get; set; }
        public string email { get; set; }

        /// <summary>
        /// Parameterised Constructor for Contact Person with below parameters
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNo">The phone no.</param>
        /// <param name="email">The email.</param>
        public ContactPerson(string firstName, string lastName, string address, string city, string state, int zip, double phoneNo, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
            this.email = email;
        }
    }
}