using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.LocalNotifications;
using Xamarin.Essentials;

namespace ASantosMobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class T1C1DetailsScreen : ContentPage
	{
        int courseNumber = 0;

        public T1C1DetailsScreen (int key)
		{
			InitializeComponent ();
            courseNumber = key;
		}

        //NAV BLOCK
        async void GoToEdit_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new T1C1EditScreen(courseNumber));
        }
        async void Back_Clicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
        //NAV BLOCK

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //CourseName
            CourseName.Text = App.CourseRepo.FetchCourseName(courseNumber);

            //CourseStart
            if (App.CourseRepo.FetchCourseStart(courseNumber) == "")
            {
                CourseStart.Text = "";
            }
            else
            {
                CourseStart.Text = App.CourseRepo.FetchCourseStart(courseNumber);
            }

            //CourseEnd
            if (App.CourseRepo.FetchCourseEnd(courseNumber) == "")
            {
                CourseEnd.Text = "";
            }
            else
            {
                CourseEnd.Text = App.CourseRepo.FetchCourseEnd(courseNumber);
            }

            //CourseStatus
            CourseStatus.Text = App.CourseRepo.FetchCourseStatus(courseNumber);

            //CourseInstructor
            CourseInstructorName.Text = App.CourseRepo.FetchCourseInstructorName(courseNumber);
            CourseInstructorPhone.Text = App.CourseRepo.FetchCourseInstructorPhone(courseNumber);
            CourseInstructorEmail.Text = App.CourseRepo.FetchCourseInstructorEmail(courseNumber);

            //Notes
            Notes.Text = App.CourseRepo.FetchCourseNotes(courseNumber);

            //DueDate
            if (App.CourseRepo.FetchCourseDueDate(courseNumber) == "")
            {
                DueDate.Text = "";
            }
            else
            {
                DueDate.Text = App.CourseRepo.FetchCourseDueDate(courseNumber);
            }

            //Objective Assessment
            OAName.Text = App.CourseRepo.FetchCourseOAName(courseNumber);
            if (App.CourseRepo.FetchOAStart(courseNumber) == "")
            {
                OAStartDate.Text = "";
            }
            else
            {
                OAStartDate.Text = App.CourseRepo.FetchOAStart(courseNumber);
            }
            if (App.CourseRepo.FetchOAEnd(courseNumber) == "")
            {
                OADueDate.Text = "";
            }
            else
            {
                OADueDate.Text = App.CourseRepo.FetchOAEnd(courseNumber);
            }

            //Performance Assessment
            PAName.Text = App.CourseRepo.FetchCoursePAName(courseNumber);
            if (App.CourseRepo.FetchPAStart(courseNumber) == "")
            {
                PAStartDate.Text = "";
            }
            else
            {
                PAStartDate.Text = App.CourseRepo.FetchPAStart(courseNumber);
            }
            if (App.CourseRepo.FetchPAEnd(courseNumber) == "")
            {
                PADueDate.Text = "";
            }
            else
            {
                PADueDate.Text = App.CourseRepo.FetchOAEnd(courseNumber);
            }
        }

        public void CourseSwitchStart_Toggled(object sender, EventArgs args)
        {          
            if (CourseStart.Text == "")
            {
                CourseStartErrorMessage.Text = "Please set Course Start Date first and retoggle to set notifications.";
            }
            else
            {
                DateTime cStart = DateTime.Parse(App.CourseRepo.FetchCourseStart(courseNumber));
                CrossLocalNotifications.Current.Show("Course Start Notification Set", $"You will be notified again on {cStart}", 1);
                CrossLocalNotifications.Current.Show($"{CourseName.Text}", $"Course has started.", 2, cStart);
                CourseStartErrorMessage.Text = "Successful! You will receive a confirmation notification shortly detailing main alert.";
            }
        }

        public void CourseSwitchEnd_Toggled(object sender, EventArgs args)
        {
            if (CourseEnd.Text == "")
            {
                CourseEndErrorMessage.Text = "Please set Course End Date first and retoggle to set notifications.";
            }
            else
            {
                DateTime cEnd = DateTime.Parse(App.CourseRepo.FetchCourseEnd(courseNumber));
                CrossLocalNotifications.Current.Show("End Date Notification Set", $"You will be notified again on {cEnd}", 1);
                CrossLocalNotifications.Current.Show($"{CourseName.Text}", $"Course has ended.", 2, cEnd);
                CourseEndErrorMessage.Text = "Successful! You will receive a confirmation notification shortly detailing main alert.";
            }
        }

        public void ShareButton_Clicked(object sender, EventArgs args)
        {
            Share.RequestAsync(new ShareTextRequest
            {
                Text = Notes.Text,
                Title = "Shared Notes"
            });
        }

        public void DueDateSwitchToggled(object sender, EventArgs args)
        {
            if (DueDate.Text == "")
            {
                DueDateErrorMessage.Text = "Please set Course Due Date first and retoggle to set notifications.";
            }
            else
            {
                DateTime cDueDate = DateTime.Parse(App.CourseRepo.FetchCourseDueDate(courseNumber));
                CrossLocalNotifications.Current.Show("Due Date Notification Set", $"You will be notified again on {cDueDate}", 1);
                CrossLocalNotifications.Current.Show($"{CourseName.Text}", $"Due Date has arrived.", 2, cDueDate);
                DueDateErrorMessage.Text = "Successful! You will receive a confirmation notification shortly detailing main alert.";
            }
        }

        public void OBJSwitch_Toggled(object sender, EventArgs args)
        {
            if (OADueDate.Text == "")
            {
                OBJErrorMessage.Text = "Please set Assessment Due Date first and retoggle to set notifications.";
            }
            else
            {
                DateTime oaDueDate = DateTime.Parse(App.CourseRepo.FetchOAEnd(courseNumber));
                CrossLocalNotifications.Current.Show("Objective Assessment Notification Set", $"You will be notified again on {oaDueDate}", 1);
                CrossLocalNotifications.Current.Show($"{OAName.Text}", $"Due Date has arrived.", 2, oaDueDate);
                OBJErrorMessage.Text = "Successful! You will receive a confirmation notification shortly detailing main alert.";
            }
        }

        public void OAStartSwitch_Toggled(object sender, EventArgs args)
        {
            if (OAStartDate.Text == "")
            {
                OAStartErrorMessage.Text = "Please set Assessment Start Date first and retoggle to set notifications.";
            }
            else
            {
                DateTime oaStartDate = DateTime.Parse(App.CourseRepo.FetchOAStart(courseNumber));
                CrossLocalNotifications.Current.Show("Objective Assessment Notification Set", $"You will be notified again on {oaStartDate}", 1);
                CrossLocalNotifications.Current.Show($"{OAName.Text}", $"Start Date has arrived.", 2, oaStartDate);
                OAStartErrorMessage.Text = "Successful! You will receive a confirmation notification shortly detailing main alert.";
            }
        }

        public void PRFSwitch_Toggled(object sender, EventArgs args)
        {
            if (PADueDate.Text == "")
            {
                PRFErrorMessage.Text = "Please set Assessment Due Date first and retoggle to set notifications.";
            }
            else
            {
                DateTime paDueDate = DateTime.Parse(App.CourseRepo.FetchPAEnd(courseNumber));
                CrossLocalNotifications.Current.Show("Performance Assessment Notification Set", $"You will be notified again on {paDueDate}", 1);
                CrossLocalNotifications.Current.Show($"{PAName.Text}", $"Due Date has arrived.", 2, paDueDate);
                PRFErrorMessage.Text = "Successful! You will receive a confirmation notification shortly detailing main alert.";
            }
        }

        public void PAStartSwitch_Toggled(object sender, EventArgs args)
        {
            if (PAStartDate.Text == "")
            {
                PAStartErrorMessage.Text = "Please set Assessment Start Date first and retoggle to set notifications.";
            }
            else
            {
                DateTime paStartDate = DateTime.Parse(App.CourseRepo.FetchOAStart(courseNumber));
                CrossLocalNotifications.Current.Show("Performance Assessment Notification Set", $"You will be notified again on {paStartDate}", 1);
                CrossLocalNotifications.Current.Show($"{PAName.Text}", $"Start Date has arrived.", 2, paStartDate);
                PAStartErrorMessage.Text = "Successful! You will receive a confirmation notification shortly detailing main alert.";
            }
        }

    }
}