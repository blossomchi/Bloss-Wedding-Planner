using App2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NextInfoPage : ContentPage
	{
		public NextInfoPage ()
		{
			InitializeComponent ();
		}

        private void SaveBride_Clicked(object sender, EventArgs e)
        {
           
            RegisterTable registerable = new RegisterTable()
            {                

                BrideName = BrideNameEntry.Text,
                BrideGender = BrideGenderEntry.Text,
                GroomName= GroomNameEntry.Text,
                GroomGender = GroomGenderEntry.Text,
                WeddingDate = WeddDateEntry.Date
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<RegisterTable>();
                var numberRow = conn.Insert(registerable);

                DateTime today = DateTime.Today;
                if (WeddDateEntry.Date <= today)
                {
                    DisplayAlert("Failure", "Wedding date cannot be less than or equal to today.", "Close");
                }
                else
                {
                    if (numberRow > 0)
                    {
                        DisplayAlert("Success", "Save Successfully. Bride Details:" + BrideNameEntry.Text + " " + "Groom Details:" + GroomNameEntry.Text + " " + "Wed Date:" + WeddDateEntry.Date, "Close");
                        Navigation.PushAsync(new LoginPage());
                    }
                    else
                    {
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                    }
                }               
            }
               
        }
    }

    
}