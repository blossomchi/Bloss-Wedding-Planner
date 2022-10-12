using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
       
        public string Couples;
		public LoginPage ()
		{
			InitializeComponent ();
            LoginImage.Source = "ring.jpg";

        }

        private void LoginInfo_Clicked(object sender, EventArgs e)
        {
            RegisterTable registerable = new RegisterTable()
            {

                BrideName = BrideInfo.Text,
                GroomName = GroomInfo.Text,
                WeddingDate = WedDateEntry.Date
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<RegisterTable>();
                //var numberRow = conn.Insert(registerable);

                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var data = db.Table<RegisterTable>();  //Call Table  
                var data1 = data.Where(x => x.BrideName == BrideInfo.Text && x.GroomName == GroomInfo.Text && x.WeddingDate == WedDateEntry.Date).FirstOrDefault(); //Linq Query  

                if (data1 != null)
                {
                    //DisplayAlert("Success", "Login Successfully.", "Close");
                    App.SessionBrideName = BrideInfo.Text;
                    App.SessionGroomName = GroomInfo.Text;
                    App.SessionWeddingDate = WedDateEntry.Date;
                    Navigation.PushAsync(new DashPage());
                }
                else
                {
                    DisplayAlert("Failure", "Information is invalid.", "Close");
                    Navigation.PushAsync(new LoginPage());
                }
               
            }
                                 
        }
    }
}