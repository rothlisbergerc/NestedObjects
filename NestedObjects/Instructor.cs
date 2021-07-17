using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual Instructor.
    /// </summary>
    class Instructor
    {
        /// <summary>
        /// Legal full name. First and last. 
        /// Example: Jane Doe.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Company email address.
        /// Example: Jane.Doe@cptc.edu.
        /// </summary>
        public string Email { get; set; }
    }
}
