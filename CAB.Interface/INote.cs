using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB.Interface
{
    public interface INote
    {
        /// <summary>
        /// unique identifier for this record - comes from database...
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// detail text for this note
        /// </summary>
        string Details { get; set; }

        /// <summary>
        /// date time stamp of the note created
        /// </summary>
        DateTime CreateOn { get; set; }
    }
}
