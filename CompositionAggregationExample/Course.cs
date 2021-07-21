using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionAggregationExample
{
    /// <summary>
    /// Represents one course that is related to a specific program.
    /// </summary>
    class Course
    {
        /// <summary>
        /// The course code and title of the course.
        /// Example: CPW 212: Advanced .NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The official course catalog description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of college credits awarded for 
        /// passing the course.
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The instructor that teaches the course.
        /// </summary>
        public Instructor CourseInstructor { get; set; }

        /// <summary>
        /// All students who are currently enrolled in the class.
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}