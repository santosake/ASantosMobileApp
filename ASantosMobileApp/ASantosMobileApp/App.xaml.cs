using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ASantosMobileApp
{
    public partial class App : Application
    {
        public static CourseRepository CourseRepo { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            CourseRepo = new CourseRepository(dbPath);
            CourseRepo.Populate();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
