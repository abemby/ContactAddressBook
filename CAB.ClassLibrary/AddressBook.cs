using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB.Interface;

namespace CAB.ClassLibrary
{
    public class AddressBook : IAddressBook
    {

        #region "   Properties  / Data Member   "

        ILogger _iLogger;

        public Countries Country { get; set; }

        public List<IContact> Contacts { get; set; }

        #endregion

        #region "   Methods / Functions "

        /// <summary>
        /// Constructor
        /// </summary>
        public AddressBook(ILogger iLogger)
        {
            Contacts = new List<IContact>();
            _iLogger = iLogger;
        }

        public void AddContact(IContact contact)
        {
            Contacts.Add(contact);
        }

        public List<IContact> FindByFirstName(string firstName)
        {
            return (from c in Contacts
                    where c.FirstName.Equals(firstName)
                    select c).ToList();
        }

        public List<IContact> FindByLastName(string lastName)
        {
            return (from c in Contacts
                    where c.LastName.Equals(lastName)
                    select c).ToList();
        }

        public bool RemoveContact(IContact contact)
        {
            return Contacts.Remove(contact);
        }

        public void Display()
        {
            var sb = new StringBuilder();

            sb.Append(Country);
            foreach (var contact in Contacts)
            {
                sb.AppendFormat("   {0}:{1}:{2}", contact.Id, contact.FirstName, contact.LastName, contact.CreatedOn.ToShortDateString());
                foreach (var note in contact.Notes)
                    sb.AppendFormat("       {0}", note.Details);
            }
            _iLogger.WriteLog(LogLevels.INFO, sb.ToString());
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            return sb.ToString();
        }

            #endregion
        }
}
