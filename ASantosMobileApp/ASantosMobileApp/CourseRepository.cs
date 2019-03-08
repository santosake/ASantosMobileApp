using System;
using System.Collections.Generic;
using System.Text;
using ASantosMobileApp.Models;
using SQLite;

namespace ASantosMobileApp
{
    public class CourseRepository
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public CourseRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Course>();
        }

        public void Populate()
        {
            conn.DeleteAll<Course>();

            //T1C1 (Populated Per PA Instructions)
            conn.Insert(new Course
            {
                CourseId = 1,
                TermTitle = "Hogwarts: Year 1",
                TermStart = "01/20/2019",
                TermEnd = "05/15/2019",
                CourseName = "Defense Against The Dark Arts",
                CourseStart = "01/20/2019",
                CourseEnd = "05/13/2019",
                CourseStatus = "In Progress",
                CourseInstructorName = "Anthony Santos",
                CourseInstructorPhone = "7023544078",
                CourseInstructorEmail = "asant69@wgu.edu",
                CourseNotes = "Prof Snape has covered the difference between Animagus and Werewolves.",
                CourseDueDate = "05/14/2019",
                CourseOAName = "Aurors and Insights",
                OAStart = "05/11/2019",
                OAEnd = "05/12/2019",
                CoursePAName = "Expelliarmus Practicum",
                PAStart = "05/12/2019",
                PAEnd = "05/13/2019",
            });

            //T1C2
            conn.Insert(new Course
            {
                CourseId = 2,
                TermTitle = "Term 1",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T1C3
            conn.Insert(new Course
            {
                CourseId = 3,
                TermTitle = "Term 1",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T1C4
            conn.Insert(new Course
            {
                CourseId = 4,
                TermTitle = "Term 1",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T1C5
            conn.Insert(new Course
            {
                CourseId = 5,
                TermTitle = "Term 1",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T1C6
            conn.Insert(new Course
            {
                CourseId = 6,
                TermTitle = "Term 1",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T2C1
            conn.Insert(new Course
            {
                CourseId = 7,
                TermTitle = "Term 2",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T2C2
            conn.Insert(new Course
            {
                CourseId = 8,
                TermTitle = "Term 2",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T2C3
            conn.Insert(new Course
            {
                CourseId = 9,
                TermTitle = "Term 2",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T2C4
            conn.Insert(new Course
            {
                CourseId = 10,
                TermTitle = "Term 2",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T2C5
            conn.Insert(new Course
            {
                CourseId = 11,
                TermTitle = "Term 2",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T2C6
            conn.Insert(new Course
            {
                CourseId = 12,
                TermTitle = "Term 2",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T3C1
            conn.Insert(new Course
            {
                CourseId = 13,
                TermTitle = "Term 3",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T3C2
            conn.Insert(new Course
            {
                CourseId = 14,
                TermTitle = "Term 3",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T3C3
            conn.Insert(new Course
            {
                CourseId = 15,
                TermTitle = "Term 3",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T3C4
            conn.Insert(new Course
            {
                CourseId = 16,
                TermTitle = "Term 3",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T3C5
            conn.Insert(new Course
            {
                CourseId = 17,
                TermTitle = "Term 3",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T3C6
            conn.Insert(new Course
            {
                CourseId = 18,
                TermTitle = "Term 3",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T4C1
            conn.Insert(new Course
            {
                CourseId = 19,
                TermTitle = "Term 4",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T4C2
            conn.Insert(new Course
            {
                CourseId = 20,
                TermTitle = "Term 4",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T4C3
            conn.Insert(new Course
            {
                CourseId = 21,
                TermTitle = "Term 4",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T4C4
            conn.Insert(new Course
            {
                CourseId = 22,
                TermTitle = "Term 4",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T4C5
            conn.Insert(new Course
            {
                CourseId = 23,
                TermTitle = "Term 4",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T4C6
            conn.Insert(new Course
            {
                CourseId = 24,
                TermTitle = "Term 4",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T5C1
            conn.Insert(new Course
            {
                CourseId = 25,
                TermTitle = "Term 5",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T5C2
            conn.Insert(new Course
            {
                CourseId = 26,
                TermTitle = "Term 5",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T5C3
            conn.Insert(new Course
            {
                CourseId = 27,
                TermTitle = "Term 5",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T5C4
            conn.Insert(new Course
            {
                CourseId = 28,
                TermTitle = "Term 5",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T5C5
            conn.Insert(new Course
            {
                CourseId = 29,
                TermTitle = "Term 5",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T5C6
            conn.Insert(new Course
            {
                CourseId = 30,
                TermTitle = "Term 5",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T6C1
            conn.Insert(new Course
            {
                CourseId = 31,
                TermTitle = "Term 6",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T6C2
            conn.Insert(new Course
            {
                CourseId = 32,
                TermTitle = "Term 6",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T6C3
            conn.Insert(new Course
            {
                CourseId = 33,
                TermTitle = "Term 6",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T6C4
            conn.Insert(new Course
            {
                CourseId = 34,
                TermTitle = "Term 6",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T6C5
            conn.Insert(new Course
            {
                CourseId = 35,
                TermTitle = "Term 6",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T6C6
            conn.Insert(new Course
            {
                CourseId = 36,
                TermTitle = "Term 6",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T7C1
            conn.Insert(new Course
            {
                CourseId = 37,
                TermTitle = "Term 7",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T7C2
            conn.Insert(new Course
            {
                CourseId = 38,
                TermTitle = "Term 7",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T7C3
            conn.Insert(new Course
            {
                CourseId = 39,
                TermTitle = "Term 7",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T7C4
            conn.Insert(new Course
            {
                CourseId = 40,
                TermTitle = "Term 7",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T7C5
            conn.Insert(new Course
            {
                CourseId = 41,
                TermTitle = "Term 7",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T7C6
            conn.Insert(new Course
            {
                CourseId = 42,
                TermTitle = "Term 7",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T8C1
            conn.Insert(new Course
            {
                CourseId = 43,
                TermTitle = "Term 8",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T8C2
            conn.Insert(new Course
            {
                CourseId = 44,
                TermTitle = "Term 8",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T8C3
            conn.Insert(new Course
            {
                CourseId = 45,
                TermTitle = "Term 8",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T8C4
            conn.Insert(new Course
            {
                CourseId = 46,
                TermTitle = "Term 8",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T8C5
            conn.Insert(new Course
            {
                CourseId = 47,
                TermTitle = "Term 8",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T8C6
            conn.Insert(new Course
            {
                CourseId = 48,
                TermTitle = "Term 8",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T9C1
            conn.Insert(new Course
            {
                CourseId = 49,
                TermTitle = "Term 9",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T9C2
            conn.Insert(new Course
            {
                CourseId = 50,
                TermTitle = "Term 9",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T9C3
            conn.Insert(new Course
            {
                CourseId = 51,
                TermTitle = "Term 9",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T9C4
            conn.Insert(new Course
            {
                CourseId = 52,
                TermTitle = "Term 9",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T9C5
            conn.Insert(new Course
            {
                CourseId = 53,
                TermTitle = "Term 9",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T9C6
            conn.Insert(new Course
            {
                CourseId = 54,
                TermTitle = "Term 9",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T10C1
            conn.Insert(new Course
            {
                CourseId = 55,
                TermTitle = "Term 10",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T10C2
            conn.Insert(new Course
            {
                CourseId = 56,
                TermTitle = "Term 10",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T10C3
            conn.Insert(new Course
            {
                CourseId = 57,
                TermTitle = "Term 10",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T10C4
            conn.Insert(new Course
            {
                CourseId = 58,
                TermTitle = "Term 10",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T10C5
            conn.Insert(new Course
            {
                CourseId = 59,
                TermTitle = "Term 10",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T10C6
            conn.Insert(new Course
            {
                CourseId = 60,
                TermTitle = "Term 10",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T11C1
            conn.Insert(new Course
            {
                CourseId = 61,
                TermTitle = "Term 11",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T11C2
            conn.Insert(new Course
            {
                CourseId = 62,
                TermTitle = "Term 11",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T11C3
            conn.Insert(new Course
            {
                CourseId = 63,
                TermTitle = "Term 11",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T11C4
            conn.Insert(new Course
            {
                CourseId = 64,
                TermTitle = "Term 11",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T11C5
            conn.Insert(new Course
            {
                CourseId = 65,
                TermTitle = "Term 11",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T11C6
            conn.Insert(new Course
            {
                CourseId = 66,
                TermTitle = "Term 11",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T12C1
            conn.Insert(new Course
            {
                CourseId = 67,
                TermTitle = "Term 12",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T12C2
            conn.Insert(new Course
            {
                CourseId = 68,
                TermTitle = "Term 12",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T12C3
            conn.Insert(new Course
            {
                CourseId = 69,
                TermTitle = "Term 12",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T12C4
            conn.Insert(new Course
            {
                CourseId = 70,
                TermTitle = "Term 12",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T12C5
            conn.Insert(new Course
            {
                CourseId = 71,
                TermTitle = "Term 12",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T12C6
            conn.Insert(new Course
            {
                CourseId = 72,
                TermTitle = "Term 12",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T13C1
            conn.Insert(new Course
            {
                CourseId = 73,
                TermTitle = "Term 13",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T13C2
            conn.Insert(new Course
            {
                CourseId = 74,
                TermTitle = "Term 13",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T13C3
            conn.Insert(new Course
            {
                CourseId = 75,
                TermTitle = "Term 13",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T13C4
            conn.Insert(new Course
            {
                CourseId = 76,
                TermTitle = "Term 13",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T13C5
            conn.Insert(new Course
            {
                CourseId = 77,
                TermTitle = "Term 13",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T13C6
            conn.Insert(new Course
            {
                CourseId = 78,
                TermTitle = "Term 13",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T14C1
            conn.Insert(new Course
            {
                CourseId = 79,
                TermTitle = "Term 14",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T14C2
            conn.Insert(new Course
            {
                CourseId = 80,
                TermTitle = "Term 14",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T14C3
            conn.Insert(new Course
            {
                CourseId = 81,
                TermTitle = "Term 14",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T14C4
            conn.Insert(new Course
            {
                CourseId = 82,
                TermTitle = "Term 14",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T14C5
            conn.Insert(new Course
            {
                CourseId = 83,
                TermTitle = "Term 14",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T14C6
            conn.Insert(new Course
            {
                CourseId = 84,
                TermTitle = "Term 14",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T15C1
            conn.Insert(new Course
            {
                CourseId = 85,
                TermTitle = "Term 15",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 1",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T15C2
            conn.Insert(new Course
            {
                CourseId = 86,
                TermTitle = "Term 15",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 2",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T15C3
            conn.Insert(new Course
            {
                CourseId = 87,
                TermTitle = "Term 15",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 3",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T15C4
            conn.Insert(new Course
            {
                CourseId = 88,
                TermTitle = "Term 15",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 4",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T15C5
            conn.Insert(new Course
            {
                CourseId = 89,
                TermTitle = "Term 15",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 5",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });

            //T15C6
            conn.Insert(new Course
            {
                CourseId = 90,
                TermTitle = "Term 15",
                TermStart = "",
                TermEnd = "",
                CourseName = "Course 6",
                CourseStart = "",
                CourseEnd = "",
                CourseStatus = "",
                CourseInstructorName = "",
                CourseInstructorPhone = "",
                CourseInstructorEmail = "",
                CourseNotes = "",
                CourseDueDate = "",
                CourseOAName = "",
                OAStart = "",
                OAEnd = "",
                CoursePAName = "",
                PAStart = "",
                PAEnd = "",
            });


        }

        public string FetchCourseId(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseId.ToString();
            return b;
        }

        //TermTitle
        public string FetchTermTitle(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].TermTitle.ToString();
            return b;
        }

        public void UpdateTermTitle(string str ,int course)
        {
            conn.Execute("UPDATE Course SET TermTitle = ? WHERE CourseId = ?", str, course);
        }

        //TermStart
        public string FetchTermStart(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].TermStart.ToString();
            return b;
        }

        public void UpdateTermStart(string str, int course)
        {
            conn.Execute("UPDATE Course SET TermStart = ? WHERE CourseId = ?", str, course);
        }

        //TermEnd
        public string FetchTermEnd(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].TermEnd.ToString();
            return b;
        }

        public void UpdateTermEnd(string str, int course)
        {
            conn.Execute("UPDATE Course SET TermEnd = ? WHERE CourseId = ?", str, course);
        }

        //CourseName
        public string FetchCourseName(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseName.ToString();
            return b;
        }

        public void UpdateCourseName(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseName = ? WHERE CourseId = ?", str, course);
        }

        //CourseStart
        public string FetchCourseStart(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseStart.ToString();
            return b;
        }

        public void UpdateCourseStart(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseStart = ? WHERE CourseId = ?", str, course);
        }

        //CourseEnd
        public string FetchCourseEnd(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseEnd.ToString();
            return b;
        }

        public void UpdateCourseEnd(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseEnd = ? WHERE CourseId = ?", str, course);
        }

        //CourseStatus
        public string FetchCourseStatus(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseStatus.ToString();
            return b;
        }

        public void UpdateCourseStatus(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseStatus = ? WHERE CourseId = ?", str, course);
        }

        //CourseInstructorName
        public string FetchCourseInstructorName(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseInstructorName.ToString();
            return b;
        }

        public void UpdateCourseInstructorName(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseInstructorName = ? WHERE CourseId = ?", str, course);
        }

       //CourseInstructorPhone
        public string FetchCourseInstructorPhone(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseInstructorPhone.ToString();
            return b;
        }

        public void UpdateCourseInstructorPhone(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseInstructorPhone = ? WHERE CourseId = ?", str, course);
        }

        //CourseInstructorEmail
        public string FetchCourseInstructorEmail(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseInstructorEmail.ToString();
            return b;
        }

        public void UpdateCourseInstructorEmail(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseInstructorEmail = ? WHERE CourseId = ?", str, course);
        }

        //CourseNotes
        public string FetchCourseNotes(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseNotes.ToString();
            return b;
        }

        public void UpdateCourseNotes(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseNotes = ? WHERE CourseId = ?", str, course);
        }

        //CourseDueDate
        public string FetchCourseDueDate(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseDueDate.ToString();
            return b;
        }

        public void UpdateCourseDueDate(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseDueDate = ? WHERE CourseId = ?", str, course);
        }

        //CourseOAName
        public string FetchCourseOAName(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CourseOAName.ToString();
            return b;
        }

        public void UpdateCourseOAName(string str, int course)
        {
            conn.Execute("UPDATE Course SET CourseOAName = ? WHERE CourseId = ?", str, course);
        }

        //OAStart
        public string FetchOAStart(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].OAStart.ToString();
            return b;
        }

        public void UpdateOAStart(string str, int course)
        {
            conn.Execute("UPDATE Course SET OAStart = ? WHERE CourseId = ?", str, course);
        }

        //OAEnd
        public string FetchOAEnd(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].OAEnd.ToString();
            return b;
        }

        public void UpdateOAEnd(string str, int course)
        {
            conn.Execute("UPDATE Course SET OAEnd = ? WHERE CourseId = ?", str, course);
        }

        //CoursePAName
        public string FetchCoursePAName(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].CoursePAName.ToString();
            return b;
        }

        public void UpdateCoursePAName(string str, int course)
        {
            conn.Execute("UPDATE Course SET CoursePAName = ? WHERE CourseId = ?", str, course);
        }

        //PAStart
        public string FetchPAStart(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].PAStart.ToString();
            return b;
        }

        public void UpdatePAStart(string str, int course)
        {
            conn.Execute("UPDATE Course SET PAStart = ? WHERE CourseId = ?", str, course);
        }

        //PAEnd
        public string FetchPAEnd(int course)
        {
            List<Course> y = conn.Table<Course>().Where(i => i.CourseId == course).ToList();
            string b = y[0].PAEnd.ToString();
            return b;
        }

        public void UpdatePAEnd(string str, int course)
        {
            conn.Execute("UPDATE Course SET PAEnd = ? WHERE CourseId = ?", str, course);
        }

    }
}
