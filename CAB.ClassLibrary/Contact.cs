using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB.Interface;

namespace CAB.ClassLibrary
{

    #region "       Contact counter sealed class           "

    /// <summary>
    /// singleton class for contact counter...
    /// </summary>
    public sealed class CounterContact : ICounter
    {
        #region "   Properties  / Data Member   "

        private int _counter { get; set; }

        static readonly CounterContact _instance = new CounterContact();
        
        public static CounterContact Instance
        {
            get
            {
                return _instance;
            }
        }

        #endregion

        #region "   Methods / Functions "


        CounterContact()
        {
            //initialise... not needed...
        }

        
        /// <summary>
        /// returns next sequence number for contacts
        /// </summary>
        /// <returns></returns>
        public int GetNext()
        {
            return _counter++;
        }

        #endregion
    }

    #endregion


    public class Contact : IContact
    {

        #region "   Properties  / Data Member   "

        public DateTime CreatedOn { get; set; }

        public string FirstName { get; set; }

        public int Id { get; set; }

        public string LastName { get; set; }

        public List<INote> Notes { get; set; }

        #endregion

        #region "   Methods / Functions "

        public Contact()
        {
            Id = CounterContact.Instance.GetNext();
            CreatedOn = DateTime.Now;
        }

        #endregion
    }
}
