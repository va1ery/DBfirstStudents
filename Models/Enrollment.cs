using System;
using System.Collections.Generic;

namespace DBfirstStudents.Models
{
    public partial class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int Grade { get; set; }
        public int CourseId { get; set; }
        public int StudentID { get; set; }
    }
}
