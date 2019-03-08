using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ASantosMobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class T1C1EditScreen : ContentPage
	{
        int courseNumber = 0;

        public T1C1EditScreen (int key)
		{
			InitializeComponent ();
            courseNumber = key;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //CourseName
            CourseName.Text = App.CourseRepo.FetchCourseName(courseNumber);

            //CourseStart
            if (App.CourseRepo.FetchCourseStart(courseNumber) == "")
            {
                CourseStart.Date = DateTime.Now;
            }
            else
            {
                CourseStart.Date = DateTime.Parse(App.CourseRepo.FetchCourseStart(courseNumber));
            }

            //CourseEnd
            if (App.CourseRepo.FetchCourseEnd(courseNumber) == "")
            {
                CourseEnd.Date = DateTime.Now;
            }
            else
            {
                CourseEnd.Date = DateTime.Parse(App.CourseRepo.FetchCourseEnd(courseNumber));
            }

            //CourseStatus
            picker.SelectedItem = App.CourseRepo.FetchCourseStatus(courseNumber);

            //CourseInstructor
            CourseInstructorName.Text = App.CourseRepo.FetchCourseInstructorName(courseNumber);
            CourseInstructorPhone.Text = App.CourseRepo.FetchCourseInstructorPhone(courseNumber);
            CourseInstructorEmail.Text = App.CourseRepo.FetchCourseInstructorEmail(courseNumber);

            //Notes
            Notes.Text = App.CourseRepo.FetchCourseNotes(courseNumber);

            //DueDate
            if (App.CourseRepo.FetchCourseDueDate(courseNumber) == "")
            {
                CourseDueDate.Date = DateTime.Now;
            }
            else
            {
                CourseDueDate.Date = DateTime.Parse(App.CourseRepo.FetchCourseDueDate(courseNumber));
            }

            //Objective Assessment
            OAName.Text = App.CourseRepo.FetchCourseOAName(courseNumber);
            if (App.CourseRepo.FetchOAStart(courseNumber) == "")
            {
                OAStart.Date = DateTime.Now;
            }
            else
            {
                OAStart.Date = DateTime.Parse(App.CourseRepo.FetchOAStart(courseNumber));
            }
            if (App.CourseRepo.FetchOAEnd(courseNumber) == "")
            {
                OAEnd.Date = DateTime.Now;
            }
            else
            {
                OAEnd.Date = DateTime.Parse(App.CourseRepo.FetchOAEnd(courseNumber));
            }

            //Performance Assessment
            PAName.Text = App.CourseRepo.FetchCoursePAName(courseNumber);
            if (App.CourseRepo.FetchPAStart(courseNumber) == "")
            {
                PAStart.Date = DateTime.Now;
            }
            else
            {
                PAStart.Date = DateTime.Parse(App.CourseRepo.FetchPAStart(courseNumber));
            }
            if (App.CourseRepo.FetchPAEnd(courseNumber) == "")
            {
                PAEnd.Date = DateTime.Now;
            }
            else
            {
                PAEnd.Date = DateTime.Parse(App.CourseRepo.FetchPAEnd(courseNumber));
            }

        }

        public void OBJDeleteButton_Clicked(object sender, EventArgs args)
        {
            App.CourseRepo.UpdateCourseOAName("", courseNumber);
            App.CourseRepo.UpdateOAStart("", courseNumber);
            App.CourseRepo.UpdateOAEnd("", courseNumber);

            OAName.Text = "";
            OAStart.Date = DateTime.Now;
            OAEnd.Date = DateTime.Now;
        }

        public void PRFDeleteButton_Clicked(object sender, EventArgs args)
        {
            App.CourseRepo.UpdateCoursePAName("", courseNumber);
            App.CourseRepo.UpdatePAStart("", courseNumber);
            App.CourseRepo.UpdatePAEnd("", courseNumber);

            PAName.Text = "";
            PAStart.Date = DateTime.Now;
            PAEnd.Date = DateTime.Now;
        }

        async void BackButton_Clicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        public void DeleteButton_Clicked(object sender, EventArgs args)
        {
            string courseName = "Course";
            if (courseNumber == 1 || courseNumber == 7 || courseNumber == 13 || courseNumber == 19 
                || courseNumber == 25 || courseNumber == 31 || courseNumber == 37 || courseNumber == 43
                || courseNumber == 49 || courseNumber == 55 || courseNumber == 61  || courseNumber == 67
                || courseNumber == 73 || courseNumber == 79 || courseNumber == 85)
            {
                courseName = "Course 1";
            }
            if (courseNumber == 2 || courseNumber == 8 || courseNumber == 14 || courseNumber == 20
                || courseNumber == 26 || courseNumber == 32 || courseNumber == 38 || courseNumber == 44
                || courseNumber == 50 || courseNumber == 56 || courseNumber == 62 || courseNumber == 68
                || courseNumber == 74 || courseNumber == 80 || courseNumber == 86)
            {
                courseName = "Course 2";
            }
            if (courseNumber == 3 || courseNumber == 9 || courseNumber == 15 || courseNumber == 21
                || courseNumber == 27 || courseNumber == 33 || courseNumber == 39 || courseNumber == 45
                || courseNumber == 51 || courseNumber == 57 || courseNumber == 63 || courseNumber == 69
                || courseNumber == 75 || courseNumber == 81 || courseNumber == 87)
            {
                courseName = "Course 3";
            }
            if (courseNumber == 4 || courseNumber == 10 || courseNumber == 16 || courseNumber == 22
                || courseNumber == 28 || courseNumber == 34 || courseNumber == 40 || courseNumber == 46
                || courseNumber == 52 || courseNumber == 58 || courseNumber == 64 || courseNumber == 70
                || courseNumber == 76 || courseNumber == 82 || courseNumber == 88)
            {
                courseName = "Course 4";
            }
            if (courseNumber == 5 || courseNumber == 11 || courseNumber == 17 || courseNumber == 23
                || courseNumber == 29 || courseNumber == 35 || courseNumber == 41 || courseNumber == 47
                || courseNumber == 53 || courseNumber == 59 || courseNumber == 65 || courseNumber == 71
                || courseNumber == 77 || courseNumber == 83 || courseNumber == 89)
            {
                courseName = "Course 5";
            }
            if (courseNumber == 6 || courseNumber == 12 || courseNumber == 18 || courseNumber == 24
                || courseNumber == 30 || courseNumber == 36 || courseNumber == 42 || courseNumber == 48
                || courseNumber == 54 || courseNumber == 60 || courseNumber == 66 || courseNumber == 72
                || courseNumber == 78 || courseNumber == 84 || courseNumber == 90)
            {
                courseName = "Course 6";
            }


            //Delete DB Data
            App.CourseRepo.UpdateCourseName($"{courseName}", courseNumber);
            App.CourseRepo.UpdateCourseStart("", courseNumber);
            App.CourseRepo.UpdateCourseEnd("", courseNumber);
            App.CourseRepo.UpdateCourseStatus("", courseNumber);
            App.CourseRepo.UpdateCourseInstructorName("", courseNumber);
            App.CourseRepo.UpdateCourseInstructorPhone("", courseNumber);
            App.CourseRepo.UpdateCourseInstructorEmail("", courseNumber);
            App.CourseRepo.UpdateCourseNotes("", courseNumber);
            App.CourseRepo.UpdateCourseDueDate("", courseNumber);
            App.CourseRepo.UpdateCourseOAName("", courseNumber);
            App.CourseRepo.UpdateOAStart("", courseNumber);
            App.CourseRepo.UpdateOAEnd("", courseNumber);
            App.CourseRepo.UpdateCoursePAName("", courseNumber);
            App.CourseRepo.UpdatePAStart("", courseNumber);
            App.CourseRepo.UpdatePAEnd("", courseNumber);

            //Reset Field Values to Default
            CourseName.Text = "";
            CourseStart.Date = DateTime.Now;
            CourseEnd.Date = DateTime.Now;
            picker.SelectedItem = "";
            CourseInstructorName.Text = "";
            CourseInstructorPhone.Text = "";
            CourseInstructorEmail.Text = "";
            Notes.Text = "";
            CourseDueDate.Date = DateTime.Now;
            OAName.Text = "";
            OAStart.Date = DateTime.Now;
            OAEnd.Date = DateTime.Now;
            PAName.Text = "";
            PAStart.Date = DateTime.Now;
            PAEnd.Date = DateTime.Now;

            ErrorMessages.Text = "Successfully deleted course.";
        }

        public void SaveButton_Clicked(object sender, EventArgs args)
        {
            int errorCount = 0;
            StringBuilder errors = new StringBuilder("Failed! Try again after correcting:");

            //Validation

            //CourseName
            if (CourseName.Text == "")
            {
                errors.Append("Enter a Course Name.");
                errorCount++;
            }

            //CourseStart < CourseEnd
            if (CourseStart.Date > CourseEnd.Date)
            {
                errors.Append("End Date must be greater than Start Date.");
                errorCount++;
            }
            //CourseStatus
            if (picker.SelectedIndex == -1)
            {
                errors.Append("Pick a Course Status selection.");
                errorCount++;
            }
            //CourseInstructorName
            if(CourseInstructorName.Text == "")
            {
                errors.Append("Enter an Instructor Name.");
                errorCount++;
            }
            //CourseInstructorPhone
            if (CourseInstructorPhone.Text == "")
            {
                errors.Append("Enter an Instructor Phone.");
                errorCount++;
            }
            //CourseInstructorEmail
            if (CourseInstructorEmail.Text == "" || !CourseInstructorEmail.Text.Contains("@")
                || !CourseInstructorEmail.Text.Contains("."))
            {
                errors.Append("Invalid Instructor Email: Can't be null and requires @ and . characters");
                errorCount++;
            }
            //Notes
                //notes does not need validation
            //CourseDueDate
                //Due date is a solo date and needs no validation
            
            //Assessment info is validated seperately and not included

            //Final Save Effort
            if (errorCount > 0)
            {
                ErrorMessages.Text = Convert.ToString(errors);
                errorCount = 0;
                errors.Clear();
                errors.Append("Failed! Try again after correcting:");
            }
            else
            {
                App.CourseRepo.UpdateCourseName(CourseName.Text, courseNumber);
                App.CourseRepo.UpdateCourseStart(Convert.ToString(CourseStart.Date.ToString("MM-dd-yyyy")), courseNumber);
                App.CourseRepo.UpdateCourseEnd(Convert.ToString(CourseEnd.Date.ToString("MM-dd-yyyy")), courseNumber);
                App.CourseRepo.UpdateCourseStatus(picker.SelectedItem.ToString(), courseNumber);
                App.CourseRepo.UpdateCourseInstructorName(CourseInstructorName.Text, courseNumber);
                App.CourseRepo.UpdateCourseInstructorPhone(CourseInstructorPhone.Text, courseNumber);
                App.CourseRepo.UpdateCourseInstructorEmail(CourseInstructorEmail.Text, courseNumber);
                App.CourseRepo.UpdateCourseNotes(Notes.Text, courseNumber);
                App.CourseRepo.UpdateCourseDueDate(Convert.ToString(CourseDueDate.Date.ToString("MM-dd-yyyy")), courseNumber);


                ErrorMessages.Text = "Success, no errors!";
            }

            

        }

        public void OASaveButton_Clicked(object sender, EventArgs args)
        {
            int oErrorCount = 0;
            StringBuilder oString = new StringBuilder("Failed! Please correct the following:");

            if (OAName.Text == "")
            {
                oString.Append("Please enter a name.");
                oErrorCount++;
            }
            if (OAStart.Date > OAEnd.Date)
            {
                oString.Append("Due Date needs to be greater than Start Date");
                oErrorCount++;
            }

            if (oErrorCount > 0)
            {
                OASaveErrors.Text = Convert.ToString(oString);
                oErrorCount = 0;
                oString.Clear();
                oString.Append("Failed! Please correct the following:");
            }
            else
            {
                App.CourseRepo.UpdateCourseOAName(OAName.Text, courseNumber);
                App.CourseRepo.UpdateOAStart(Convert.ToString(OAStart.Date.ToString("MM-dd-yyyy")), courseNumber);
                App.CourseRepo.UpdateOAEnd(Convert.ToString(OAEnd.Date.ToString("MM-dd-yyyy")), courseNumber);

                OASaveErrors.Text = "Success! No errors.";
            }
        }

        public void PASaveButton_Clicked(object sender, EventArgs args)
        {
            int pErrorCount = 0;
            StringBuilder pString = new StringBuilder("Failed! Please correct the following:");

            if (PAName.Text == "")
            {
                pString.Append("Please enter a name.");
                pErrorCount++;
            }
            if (PAStart.Date > PAEnd.Date)
            {
                pString.Append("Due Date needs to be greater than Start Date");
                pErrorCount++;
            }

            if (pErrorCount > 0)
            {
                PASaveErrors.Text = Convert.ToString(pString);
                pErrorCount = 0;
                pString.Clear();
                pString.Append("Failed! Please correct the following:");
            }
            else
            {
                App.CourseRepo.UpdateCoursePAName(PAName.Text, courseNumber);
                App.CourseRepo.UpdatePAStart(Convert.ToString(PAStart.Date.ToString("MM-dd-yyyy")), courseNumber);
                App.CourseRepo.UpdatePAEnd(Convert.ToString(PAEnd.Date.ToString("MM-dd-yyyy")), courseNumber);

                PASaveErrors.Text = "Success! No errors.";
            }
        }
    }
}