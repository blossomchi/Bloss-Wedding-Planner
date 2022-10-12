using App2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodDrinksPage : ContentPage
	{
        public int CouplesID;
        public string BrideName;
        public string GroomName;

        public FoodDrinksPage ()
		{
			InitializeComponent ();
            Continental.Source = "food1.jpg";
            Intercontinental.Source = "food6.jpg";

            BrideName = App.SessionBrideName;
            GroomName = App.SessionGroomName;

            if (BrideName == null && GroomName == null)
            { Navigation.PushAsync(new LoginPage()); }

            //get couples id
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
            var db = new SQLite.SQLiteConnection(dpPath);
            var data = db.Table<RegisterTable>();  //Call Table  
            var data1 = data.Where(x => x.BrideName == BrideName && x.GroomName == GroomName).SingleOrDefault().CusID; //Linq Query  

            CouplesID = data1;

        }

        private void Continental_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContinentalPage());
        }

        private void Intercontinental_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IntercontinentalPage());
        }
    }
}