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
	public partial class Term1DetailsScreen : ContentPage
	{
        int courseNumber = 0;

        public Term1DetailsScreen (int key)
		{
			InitializeComponent ();
            courseNumber = key;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Term1
            TermTitle.Text = App.CourseRepo.FetchTermTitle(courseNumber);
            if (App.CourseRepo.FetchTermStart(courseNumber) == "")
            {
                TermStart.Text = "";
            }
            else
            {
                TermStart.Text = App.CourseRepo.FetchTermStart(courseNumber);
            }
            if (App.CourseRepo.FetchTermEnd(courseNumber) == "")
            {
                TermEnd.Text = "";
            }
            else
            {
                TermEnd.Text = App.CourseRepo.FetchTermEnd(courseNumber);
            }

            //Course 1
            int course1Tracker = courseNumber;
            Course1.Text = App.CourseRepo.FetchCourseName(course1Tracker);
            //Course 2
            int course2Tracker = courseNumber + 1;
            Course2.Text = App.CourseRepo.FetchCourseName(course2Tracker);
            //Course 3
            int course3Tracker = courseNumber + 2;
            Course3.Text = App.CourseRepo.FetchCourseName(course3Tracker);
            //Course 4
            int course4Tracker = courseNumber + 3;
            Course4.Text = App.CourseRepo.FetchCourseName(course4Tracker);
            //Course 5
            int course5Tracker = courseNumber + 4;
            Course5.Text = App.CourseRepo.FetchCourseName(course5Tracker);
            //Course 6
            int course6Tracker = courseNumber + 5;
            Course6.Text = App.CourseRepo.FetchCourseName(course6Tracker);
        }

        async void BackButton_Clicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        async void C1_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new T1C1DetailsScreen(courseNumber));
        }

        async void C2_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new T1C1DetailsScreen(courseNumber + 1));
        }

        async void C3_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new T1C1DetailsScreen(courseNumber + 2));
        }

        async void C4_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new T1C1DetailsScreen(courseNumber + 3));
        }

        async void C5_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new T1C1DetailsScreen(courseNumber + 4));
        }

        async void C6_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new T1C1DetailsScreen(courseNumber + 5));
        }
    }
}