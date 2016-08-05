using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB.Interface
{
    public interface IContact
    {
        /// <summary>
        /// unique identifier for this record
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// first name of contact
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// last name of contact
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        DateTime CreatedOn { get; set; }

        List<INote> Notes { get; set; }        
    }
}
