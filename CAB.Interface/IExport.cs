using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB.Interface
{
    public enum Options
    {
        TEXT
    }

    public interface IExport
    {
        bool ExportTo(Options option, IAddressBook addressBook);
    }
}
