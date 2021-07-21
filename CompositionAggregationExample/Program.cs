using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionAggregationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /* created test code */

            // one instructor 
            Instructor currInstructor = new Instructor()
            {
                FullName = "John Smith",
                Email = "John.Smith@university.edu"
            };

            // students
            Student s1 = new Student()
            {
                FirstName = "Tommy",
                LastName = "Pickels"
            };

            Student s2 = new Student()
            {
                FirstName = "Angelica",
                LastName = "Pickles"
            };

            Student s3 = new Student()
            {
                FirstName = "Chuckie",
                LastName = "Finster"
            };

            Student s4 = new Student()
            {
                FirstName = "Susie",
                LastName = "Carmichael"
            };

            Student s5 = new Student()
            {
                FirstName = "Lillian",
                LastName = "Deville"
            };

            Student s6 = new Student()
            {
                FirstName = "Phillip",
                LastName = "Deville"
            };

            // course
            Course testCourse = new Course();
            testCourse.Title = "CPW 212: Advanced .NET Programming";
            testCourse.Description = "Implementing .NET with Object Oriented Programming concepts.";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInstructor;
            testCourse.Roster = new List<Student>();

            // add students to course
            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);
            testCourse.Roster.Add(s4);
            testCourse.Roster.Add(s5);
            testCourse.Roster.Add(s6);

            // read data
            Console.WriteLine(testCourse.Title);
            Console.WriteLine("Instructor: " +
                testCourse.CourseInstructor.FullName);

            // for loop: list of all students
            Console.WriteLine("Enrolled Students: ");
            foreach (Student s in testCourse.Roster) 
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }

            // keeps the program open
            Console.ReadKey();
        }
    }
}