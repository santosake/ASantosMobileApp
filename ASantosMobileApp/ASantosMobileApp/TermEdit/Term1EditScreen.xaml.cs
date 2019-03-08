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
	public partial class Term1EditScreen : ContentPage
	{
        int courseNumber = 0;
        int errorCount = 0;
        StringBuilder errors = new StringBuilder("Failed! Try again after correcting:");

        public Term1EditScreen (int key)
		{
			InitializeComponent ();
            courseNumber = key;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //TermInfoPopulation
            TermTitle.Text = App.CourseRepo.FetchTermTitle(courseNumber);
            if (App.CourseRepo.FetchTermStart(courseNumber) == "")
            {
                TermStart.Date = DateTime.Now;
            }
            else
            {
                TermStart.Date = DateTime.Parse(App.CourseRepo.FetchTermStart(courseNumber));
            }
            if (App.CourseRepo.FetchTermEnd(courseNumber) == "")
            {
                TermEnd.Date = DateTime.Now;
            }
            else
            {
                TermEnd.Date = DateTime.Parse(App.CourseRepo.FetchTermEnd(courseNumber));
            }
        }

        async void BackButton_Clicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        public void SaveButton_Clicked(object sender, EventArgs args)
        {
            //Validation
            if (TermTitle.Text == "")
            {
                errors.Append("Term Title can't be null.");
                errorCount++;
            }
            if (TermStart.Date > TermEnd.Date)
            {
                errors.Append("End Date must be greater than Start Date");
                errorCount++;
            }
            if (errorCount > 0)
            {
                ErrorMessageDisplay.Text = Convert.ToString(errors);
                errorCount = 0;
                errors.Clear();
                errors.Append("Failed! Try again after correcting:");
            }
            else
            {
                App.CourseRepo.UpdateTermTitle(TermTitle.Text, courseNumber);
                App.CourseRepo.UpdateTermStart(Convert.ToString(TermStart.Date.ToString("MM-dd-yyyy")), courseNumber);
                App.CourseRepo.UpdateTermEnd(Convert.ToString(TermEnd.Date.ToString("MM-dd-yyyy")), courseNumber);

                ErrorMessageDisplay.Text = "Success, no errors!";
            }
        }

        public void DeleteButton_Clicked(object sender, EventArgs args)
        {
            string termConverted = "Term";
            if (courseNumber == 1)
            {
                termConverted = "Term 1";
            }
            if (courseNumber == 7)
            {
                termConverted = "Term 2";
            }
            if (courseNumber == 13)
            {
                termConverted = "Term 3";
            }
            if (courseNumber == 19)
            {
                termConverted = "Term 4";
            }
            if (courseNumber == 25)
            {
                termConverted = "Term 5";
            }
            if (courseNumber == 31)
            {
                termConverted = "Term 6";
            }
            if (courseNumber == 37)
            {
                termConverted = "Term 7";
            }
            if (courseNumber == 43)
            {
                termConverted = "Term 8";
            }
            if (courseNumber == 49)
            {
                termConverted = "Term 9";
            }
            if (courseNumber == 55)
            {
                termConverted = "Term 10";
            }
            if (courseNumber == 61)
            {
                termConverted = "Term 11";
            }
            if (courseNumber == 67)
            {
                termConverted = "Term 12";
            }
            if (courseNumber == 73)
            {
                termConverted = "Term 13";
            }
            if (courseNumber == 79)
            {
                termConverted = "Term 14";
            }
            if (courseNumber == 85)
            {
                termConverted = "Term 15";
            }

            App.CourseRepo.UpdateTermTitle($"{termConverted}", courseNumber);
            App.CourseRepo.UpdateTermStart("", courseNumber);
            App.CourseRepo.UpdateTermEnd("",courseNumber);

            //reset fields to default
            TermTitle.Text = "";
            TermStart.Date = DateTime.Now;
            TermEnd.Date = DateTime.Now;

            //deleting corresponding courses
            int courseTracked = courseNumber;

            //TermCourse1
            App.CourseRepo.UpdateCourseName("Course 1", courseTracked);
            App.CourseRepo.UpdateCourseStart("", courseTracked);
            App.CourseRepo.UpdateCourseEnd("", courseTracked);
            App.CourseRepo.UpdateCourseStatus("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorName("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorPhone("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorEmail("", courseTracked);
            App.CourseRepo.UpdateCourseNotes("", courseTracked);
            App.CourseRepo.UpdateCourseDueDate("", courseTracked);
            App.CourseRepo.UpdateCourseOAName("", courseTracked);
            App.CourseRepo.UpdateOAStart("", courseTracked);
            App.CourseRepo.UpdateOAEnd("", courseTracked);
            App.CourseRepo.UpdateCoursePAName("", courseTracked);
            App.CourseRepo.UpdatePAStart("", courseTracked);
            App.CourseRepo.UpdatePAEnd("", courseTracked);


            //TermCourse2
            courseTracked++;
            App.CourseRepo.UpdateCourseName("Course 2", courseTracked);
            App.CourseRepo.UpdateCourseStart("", courseTracked);
            App.CourseRepo.UpdateCourseEnd("", courseTracked);
            App.CourseRepo.UpdateCourseStatus("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorName("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorPhone("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorEmail("", courseTracked);
            App.CourseRepo.UpdateCourseNotes("", courseTracked);
            App.CourseRepo.UpdateCourseDueDate("", courseTracked);
            App.CourseRepo.UpdateCourseOAName("", courseTracked);
            App.CourseRepo.UpdateOAStart("", courseTracked);
            App.CourseRepo.UpdateOAEnd("", courseTracked);
            App.CourseRepo.UpdateCoursePAName("", courseTracked);
            App.CourseRepo.UpdatePAStart("", courseTracked);
            App.CourseRepo.UpdatePAEnd("", courseTracked);

            //TermCourse3
            courseTracked++;
            App.CourseRepo.UpdateCourseName("Course 3", courseTracked);
            App.CourseRepo.UpdateCourseStart("", courseTracked);
            App.CourseRepo.UpdateCourseEnd("", courseTracked);
            App.CourseRepo.UpdateCourseStatus("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorName("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorPhone("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorEmail("", courseTracked);
            App.CourseRepo.UpdateCourseNotes("", courseTracked);
            App.CourseRepo.UpdateCourseDueDate("", courseTracked);
            App.CourseRepo.UpdateCourseOAName("", courseTracked);
            App.CourseRepo.UpdateOAStart("", courseTracked);
            App.CourseRepo.UpdateOAEnd("", courseTracked);
            App.CourseRepo.UpdateCoursePAName("", courseTracked);
            App.CourseRepo.UpdatePAStart("", courseTracked);
            App.CourseRepo.UpdatePAEnd("", courseTracked);

            //TermCourse4
            courseTracked++;
            App.CourseRepo.UpdateCourseName("Course 4", courseTracked);
            App.CourseRepo.UpdateCourseStart("", courseTracked);
            App.CourseRepo.UpdateCourseEnd("", courseTracked);
            App.CourseRepo.UpdateCourseStatus("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorName("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorPhone("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorEmail("", courseTracked);
            App.CourseRepo.UpdateCourseNotes("", courseTracked);
            App.CourseRepo.UpdateCourseDueDate("", courseTracked);
            App.CourseRepo.UpdateCourseOAName("", courseTracked);
            App.CourseRepo.UpdateOAStart("", courseTracked);
            App.CourseRepo.UpdateOAEnd("", courseTracked);
            App.CourseRepo.UpdateCoursePAName("", courseTracked);
            App.CourseRepo.UpdatePAStart("", courseTracked);
            App.CourseRepo.UpdatePAEnd("", courseTracked);

            //TermCourse5
            courseTracked++;
            App.CourseRepo.UpdateCourseName("Course 5", courseTracked);
            App.CourseRepo.UpdateCourseStart("", courseTracked);
            App.CourseRepo.UpdateCourseEnd("", courseTracked);
            App.CourseRepo.UpdateCourseStatus("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorName("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorPhone("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorEmail("", courseTracked);
            App.CourseRepo.UpdateCourseNotes("", courseTracked);
            App.CourseRepo.UpdateCourseDueDate("", courseTracked);
            App.CourseRepo.UpdateCourseOAName("", courseTracked);
            App.CourseRepo.UpdateOAStart("", courseTracked);
            App.CourseRepo.UpdateOAEnd("", courseTracked);
            App.CourseRepo.UpdateCoursePAName("", courseTracked);
            App.CourseRepo.UpdatePAStart("", courseTracked);
            App.CourseRepo.UpdatePAEnd("", courseTracked);

            //TermCourse6
            courseTracked++;
            App.CourseRepo.UpdateCourseName("Course 6", courseTracked);
            App.CourseRepo.UpdateCourseStart("", courseTracked);
            App.CourseRepo.UpdateCourseEnd("", courseTracked);
            App.CourseRepo.UpdateCourseStatus("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorName("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorPhone("", courseTracked);
            App.CourseRepo.UpdateCourseInstructorEmail("", courseTracked);
            App.CourseRepo.UpdateCourseNotes("", courseTracked);
            App.CourseRepo.UpdateCourseDueDate("", courseTracked);
            App.CourseRepo.UpdateCourseOAName("", courseTracked);
            App.CourseRepo.UpdateOAStart("", courseTracked);
            App.CourseRepo.UpdateOAEnd("", courseTracked);
            App.CourseRepo.UpdateCoursePAName("", courseTracked);
            App.CourseRepo.UpdatePAStart("", courseTracked);
            App.CourseRepo.UpdatePAEnd("", courseTracked);

            ErrorMessageDisplay.Text = "Successfully deleted Term and Term's courses.";
        }
    }
}