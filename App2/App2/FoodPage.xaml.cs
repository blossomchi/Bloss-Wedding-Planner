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
	public partial class FoodPage : ContentPage
	{
        public int CouplesID;
        public string BrideName;
        public string GroomName;

        public FoodPage ()
		{
			InitializeComponent ();
            Img1.Source = "food3.jpg";
            Img2.Source = "food4.jpg";
            Img3.Source = "food5.jpg";

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

        private void Img1_Clicked(object sender, EventArgs e)
        {
           
            NewFoodTable newFoodTable = new NewFoodTable()
            {
                FoodName = "Pounded Yam",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<NewFoodTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataFood = db.Table<NewFoodTable>();  //Call Table  
                var checkExist = dataFood.Where(x => x.FoodName == "Pounded Yam" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Pounded yam has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(newFoodTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Pounded yam was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }             
        }

        private void Img2_Clicked(object sender, EventArgs e)
        {
            NewFoodTable newFoodTable = new NewFoodTable()
            {
                FoodName = "Joll Of Rice",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<NewFoodTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataFood = db.Table<NewFoodTable>();  //Call Table  
                var checkExist = dataFood.Where(x => x.FoodName == "Joll Of Rice" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Joll Of Rice has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(newFoodTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Joll Of Rice was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }

        }

        private void Img3_Clicked(object sender, EventArgs e)
        {
            NewFoodTable newFoodTable = new NewFoodTable()
            {
                FoodName = "Africa Salad",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<NewFoodTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataFood = db.Table<NewFoodTable>();  //Call Table  
                var checkExist = dataFood.Where(x => x.FoodName == "Africa Salad" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Africa Salad has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(newFoodTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Africa Salad was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }
        }
    }
}