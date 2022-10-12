using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App2
{
    public partial class App : Application
    {
        
        public static string DB_PATH = string.Empty;
        public static string SessionBrideName;
        public static string SessionGroomName;
        public static DateTime SessionWeddingDate;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string DB_path)
        {
            InitializeComponent();

            DB_PATH = DB_path;

            MainPage = new NavigationPage(new MainPage());

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
