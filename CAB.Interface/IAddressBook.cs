using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB.Interface
{

    public enum Countries
    {
        UK,
        USA
    }

    public interface IAddressBook
    {
        /// <summary>
        /// country of address book - from enum
        /// </summary>
        Countries Country { get; set; }

        /// <summary>
        /// list to hold all contacts for this address book
        /// </summary>
        List<IContact> Contacts { get; set; }

        /// <summary>
        /// Method to add new contact in the list
        /// </summary>
        void AddContact(IContact contact);

        /// <summary>
        /// Method to remove contact from the list
        /// </summary>
        /// <param name="name"></param>
        bool RemoveContact(IContact contact);

        /// <summary>
        /// function to find all contacts by first name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        List<IContact> FindByFirstName(string firstName);
        
        /// <summary>
        /// function to find all contacts by last name
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        List<IContact> FindByLastName(string lastName);        
    }
}
