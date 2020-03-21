using System;
using System.Collections.Generic;

namespace DBfirstStudents.Models
{
    public partial class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
