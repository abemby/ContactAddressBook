using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAB.Interface;

namespace CAB.ExportLibrary
{
    public class Export : IExport
    {
        /// <summary>
        /// A simple export to <option> IExport implementation.
        /// </summary>
        /// <param name="option"></param>
        public bool ExportTo(Options option, IAddressBook addressBook)
        {
            //throw new NotImplementedException();
            return false;
        }
    }
}
