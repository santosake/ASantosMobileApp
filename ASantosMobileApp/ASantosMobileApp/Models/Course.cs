using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ASantosMobileApp.Models
{
    [Table("course")]
    public class Course
    {
        [SQLite.PrimaryKey]
        public int CourseId { get; set; }

        public string TermTitle { get; set; }

        public string TermStart { get; set; }

        public string TermEnd { get; set; }

        public string CourseName { get; set; }

        public string CourseEnd { get; set; }

        public string CourseStart { get; set; }

        public string CourseStatus { get; set; }

        public string CourseInstructorName { get; set; }

        public string CourseInstructorPhone { get; set; }

        public string CourseInstructorEmail { get; set; }

        public string CourseNotes { get; set; }

        public string CourseDueDate { get; set; }

        public string CourseOAName { get; set; }

        public string OAStart { get; set; }

        public string OAEnd { get; set; }

        public string CoursePAName { get; set; }

        public string PAStart { get; set; }

        public string PAEnd { get; set; }
    }
}
