using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionAggregationExample
{
    /// <summary>
    /// Represents an Individual Instructor
    /// </summary>
    class Instructor
    {
        /// <summary>
        /// Instructor's legal first and last name
        /// Example: Jane Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Company's email address
        /// Example: Jane.Doe@university.edu
        /// </summary>
        public string Email { get; set; }
    }
}