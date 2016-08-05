using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB.Interface;

using CAB.ConsoleLogger;
using CAB.ClassLibrary;
using CAB.ExportLibrary;

namespace CAB.HostApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new CAB.ConsoleLogger.ConsoleLogger();

            var abUK = new AddressBook(logger);
            abUK.Country = Countries.UK;
            abUK.AddContact(fnGetContacts());
            abUK.AddContact(fnGetContacts());
            abUK.Display();
            Console.ReadKey();
        }

        private static IContact fnGetContacts()
        {            
            //contact
            var ukContact = new Contact();
            ukContact.FirstName = "Andy";
            ukContact.LastName = "Murry";

            //contacts notes
            var notes = new List<INote>();
            notes.Add(new Note() { Details = "Note 1" });
            notes.Add(new Note() { Details = "Note 2" });
            notes.Add(new Note() { Details = "Note 3" });

            ukContact.Notes = notes;

            return ukContact;
        }
    }
}
