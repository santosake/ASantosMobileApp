using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace ASantosMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Term1
            Term1Title.Text = App.CourseRepo.FetchTermTitle(1);
            Term1Start.Text = App.CourseRepo.FetchTermStart(1);
            Term1End.Text = App.CourseRepo.FetchTermEnd(1);

            //Term2
            Term2Title.Text = App.CourseRepo.FetchTermTitle(7);
            Term2Start.Text = App.CourseRepo.FetchTermStart(7);
            Term2End.Text = App.CourseRepo.FetchTermEnd(7);

            //Term3
            Term3Title.Text = App.CourseRepo.FetchTermTitle(13);
            Term3Start.Text = App.CourseRepo.FetchTermStart(13);
            Term3End.Text = App.CourseRepo.FetchTermEnd(13);

            //Term4
            Term4Title.Text = App.CourseRepo.FetchTermTitle(19);
            Term4Start.Text = App.CourseRepo.FetchTermStart(19);
            Term4End.Text = App.CourseRepo.FetchTermEnd(19);

            //Term5
            Term5Title.Text = App.CourseRepo.FetchTermTitle(25);
            Term5Start.Text = App.CourseRepo.FetchTermStart(25);
            Term5End.Text = App.CourseRepo.FetchTermEnd(25);

            //Term6
            Term6Title.Text = App.CourseRepo.FetchTermTitle(31);
            Term6Start.Text = App.CourseRepo.FetchTermStart(31);
            Term6End.Text = App.CourseRepo.FetchTermEnd(31);

            //Term7
            Term7Title.Text = App.CourseRepo.FetchTermTitle(37);
            Term7Start.Text = App.CourseRepo.FetchTermStart(37);
            Term7End.Text = App.CourseRepo.FetchTermEnd(37);

            //Term8
            Term8Title.Text = App.CourseRepo.FetchTermTitle(43);
            Term8Start.Text = App.CourseRepo.FetchTermStart(43);
            Term8End.Text = App.CourseRepo.FetchTermEnd(43);

            //Term9
            Term9Title.Text = App.CourseRepo.FetchTermTitle(49);
            Term9Start.Text = App.CourseRepo.FetchTermStart(49);
            Term9End.Text = App.CourseRepo.FetchTermEnd(49);

            //Term10
            Term10Title.Text = App.CourseRepo.FetchTermTitle(55);
            Term10Start.Text = App.CourseRepo.FetchTermStart(55);
            Term10End.Text = App.CourseRepo.FetchTermEnd(55);

            //Term11
            Term11Title.Text = App.CourseRepo.FetchTermTitle(61);
            Term11Start.Text = App.CourseRepo.FetchTermStart(61);
            Term11End.Text = App.CourseRepo.FetchTermEnd(61);

            //Term12
            Term12Title.Text = App.CourseRepo.FetchTermTitle(67);
            Term12Start.Text = App.CourseRepo.FetchTermStart(67);
            Term12End.Text = App.CourseRepo.FetchTermEnd(67);

            //Term13
            Term13Title.Text = App.CourseRepo.FetchTermTitle(73);
            Term13Start.Text = App.CourseRepo.FetchTermStart(73);
            Term13End.Text = App.CourseRepo.FetchTermEnd(73);

            //Term14
            Term14Title.Text = App.CourseRepo.FetchTermTitle(79);
            Term14Start.Text = App.CourseRepo.FetchTermStart(79);
            Term14End.Text = App.CourseRepo.FetchTermEnd(79);

            //Term15
            Term15Title.Text = App.CourseRepo.FetchTermTitle(85);
            Term15Start.Text = App.CourseRepo.FetchTermStart(85);
            Term15End.Text = App.CourseRepo.FetchTermEnd(85);
        }

        //AddTermMethod
        int addTermTracker = 0;
        public void AddTermButton_Clicked(object sender, EventArgs args)
        {
            switch (addTermTracker)
            {
                case 0:
                    //make term 2 visible
                    Term2Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 1:
                    //make term visible
                    Term3Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 2:
                    //make term visible
                    Term4Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 3:
                    //make term visible
                    Term5Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 4:
                    //make term visible
                    Term6Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 5:
                    //make term visible
                    Term7Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 6:
                    //make term visible
                    Term8Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 7:
                    //make term visible
                    Term9Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 8:
                    //make term visible
                    Term10Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 9:
                    //make term visible
                    Term11Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 10:
                    //make term visible
                    Term12Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 11:
                    //make term visible
                    Term13Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 12:
                    //make term visible
                    Term14Frame.IsVisible = true;
                    addTermTracker++;
                    break;
                case 13:
                    //make term visible
                    Term15Frame.IsVisible = true;
                    addTermTracker++;
                    break;
            }
        }

        //Term1
        async void EditTerm1_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(1));
        }

        async void DetailsTerm1_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(1));
        }


        //Term2
        async void EditTerm2_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(7));
        }

        async void DetailsTerm2_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(7));
        }

        //Term3
        async void EditTerm3_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(13));
        }

        async void DetailsTerm3_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(13));
        }

        //Term4
        async void EditTerm4_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(19));
        }

        async void DetailsTerm4_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(19));
        }

        //Term5
        async void EditTerm5_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(25));
        }

        async void DetailsTerm5_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(25));
        }

        //Term6
        async void EditTerm6_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(31));
        }

        async void DetailsTerm6_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(31));
        }

        //Term7
        async void EditTerm7_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(37));
        }

        async void DetailsTerm7_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(37));
        }

        //Term8
        async void EditTerm8_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(43));
        }

        async void DetailsTerm8_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(43));
        }

        //Term9
        async void EditTerm9_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(49));
        }

        async void DetailsTerm9_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(49));
        }

        //Term10
        async void EditTerm10_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(55));
        }

        async void DetailsTerm10_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(55));
        }

        //Term11
        async void EditTerm11_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(61));
        }

        async void DetailsTerm11_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(61));
        }

        //Term12
        async void EditTerm12_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(67));
        }

        async void DetailsTerm12_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(67));
        }

        //Term13
        async void EditTerm13_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(73));
        }

        async void DetailsTerm13_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(73));
        }

        //Term14
        async void EditTerm14_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(79));
        }

        async void DetailsTerm14_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(79));
        }

        //Term15
        async void EditTerm15_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1EditScreen(85));
        }

        async void DetailsTerm15_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Term1DetailsScreen(85));
        }
    }
}
