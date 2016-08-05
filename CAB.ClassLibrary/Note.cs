using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB.Interface;


namespace CAB.ClassLibrary
{

    #region "       Note counter sealed class           "
	

    /// <summary>
    /// singleton class for contact counter...
    /// </summary>
    sealed class NoteContact : ICounter
    {
        #region "   Properties  / Data Member   "

        private int _counter { get; set; }

        static readonly NoteContact _instance = new NoteContact();

        public static NoteContact Instance
        {
            get
            {
                return _instance;
            }
        }

        #endregion

        #region "   Methods / Functions "


        NoteContact()
        {
            //initialise... not needed...
        }

        /// <summary>
        /// return next sequence number...
        /// </summary>
        /// <returns></returns>
        public int GetNext()
        {
            return _counter++;
        }

        #endregion
    }

    #endregion

    public class Note : INote
    {
        #region "   Properties  / Data Member   "

        public DateTime CreateOn { get; set; }

        public int Id { get; set; }

        public string Details { get; set; }

        #endregion

        #region "   Methods / Functions "

        public Note()
        {
            Id = NoteContact.Instance.GetNext();
            CreateOn = DateTime.Now;
        }

        #endregion
    }
}
