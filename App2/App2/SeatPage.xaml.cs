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
	public partial class SeatPage : ContentPage
	{
        public int CouplesID;
        public string BrideName;
        public string GroomName;
        public DateTime WeddingDate;
        public SeatPage ()
		{
			InitializeComponent ();
            Img1.Source = "hall1.jpg";
            Img2.Source = "hall2.jpg";
            Img3.Source =  "chida.jpg"; 
            Img4.Source = "Spring.jpg"; 
            Img5.Source = "palazzo.jpeg"; 
            Img6.Source = "hall10.jpg"; 
            Img7.Source = "Panda.jpg"; 
          
            BrideName = App.SessionBrideName;
            GroomName = App.SessionGroomName;
            WeddingDate = App.SessionWeddingDate;

            if (BrideName == null && GroomName == null && WeddingDate == null )
            { Navigation.PushAsync(new LoginPage()); }

            //get couples id
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
            var db = new SQLite.SQLiteConnection(dpPath);
            var data = db.Table<RegisterTable>();  //Call Table  
            var data1 = data.Where(x => x.BrideName == BrideName && x.GroomName == GroomName && x.WeddingDate == WeddingDate).SingleOrDefault().CusID; //Linq Query  

            CouplesID = data1;
        }

        private void Img1_Clicked(object sender, EventArgs e)
        {
            SeatsTable seatsTable = new SeatsTable()
            {
                VenueName = "Wellington Main",
                VenuelocationName = "Warri Delta State",
                ContactName = "xxxxxxxx",
                CostName = "₦360,000",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<SeatsTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataSeat = db.Table<SeatsTable>();  //Call Table  
                var checkExist = dataSeat.Where(x => x.VenueName == "Wellington Main" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Wellington Main has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(seatsTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Wellington Main Hall was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }
        }

        private void Img2_Clicked(object sender, EventArgs e)
        {
            SeatsTable seatsTable = new SeatsTable()
            {
                VenueName = "Shereton Hall2",
                VenuelocationName = "Abuja",
                ContactName = "xxxxxxxx",
                CostName = "₦260,000",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<SeatsTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataSeat = db.Table<SeatsTable>();  //Call Table  
                var checkExist = dataSeat.Where(x => x.VenueName == "Shereton Hall2" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Shereton Hall2 has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(seatsTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Shereton Hall2 was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }
         }

        private void Img3_Clicked(object sender, EventArgs e)
        {
            SeatsTable seatsTable = new SeatsTable()
            {
                VenueName = "Chida International Hotel",
                VenuelocationName = "Abuja",
                ContactName = "xxxxxxxx",
                CostName = "₦250, 000",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<SeatsTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataSeat = db.Table<SeatsTable>();  //Call Table  
                var checkExist = dataSeat.Where(x => x.VenueName == "Chida International Hotel" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Chida International Hotel has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(seatsTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Chida International Hotel was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }
        }

        private void Img4_Clicked(object sender, EventArgs e)
        {
            SeatsTable seatsTable = new SeatsTable()
            {
                VenueName = "Spring Place Event Centre",
                VenuelocationName = "Port Harcourt",
                ContactName = "xxxxxxxx",
                CostName = "₦300,000 to ₦1,000,000",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<SeatsTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataSeat = db.Table<SeatsTable>();  //Call Table  
                var checkExist = dataSeat.Where(x => x.VenueName == "Spring Place Event Centre" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Spring Place Event Centre has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(seatsTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Spring Place Event Centre was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }
        }

        private void Img5_Clicked(object sender, EventArgs e)
        {
            SeatsTable seatsTable = new SeatsTable()
            {
                VenueName = "Palazzo Dumont",
                VenuelocationName = "Lagos",
                ContactName = "xxxxxxxx",
                CostName = "₦250,000",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<SeatsTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataSeat = db.Table<SeatsTable>();  //Call Table  
                var checkExist = dataSeat.Where(x => x.VenueName == "Palazzo Dumont" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Palazzo Dumont has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(seatsTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Palazzo Dumont was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }
        }

        private void Img6_Clicked(object sender, EventArgs e)
        {
            SeatsTable seatsTable = new SeatsTable()
            {
                VenueName = "Etal Hotels and Halls",
                VenuelocationName = "Lagos",
                ContactName = "xxxxxxxx",
                CostName = "₦450, 000",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<SeatsTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataSeat = db.Table<SeatsTable>();  //Call Table  
                var checkExist = dataSeat.Where(x => x.VenueName == "Etal Hotels and Halls" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Etal Hotels and Halls has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(seatsTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Etal Hotels and Halls was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }
        }

        private void Img7_Clicked(object sender, EventArgs e)
        {
            SeatsTable seatsTable = new SeatsTable()
            {
                VenueName = "Panda Event Centre",
                VenuelocationName = "Lagos",
                ContactName = "xxxxxxxx",
                CostName = "₦260,000",
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<SeatsTable>();

                //check if food already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataSeat = db.Table<SeatsTable>();  //Call Table  
                var checkExist = dataSeat.Where(x => x.VenueName == "Panda Event Centre" && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Panda Event Centre has already been added.", "Close");
                }
                else
                {
                    var numberRow = conn.Insert(seatsTable);

                    if (numberRow > 0)
                        DisplayAlert("Great", "Panda Event Centre was selected.", "Close");
                    else
                        DisplayAlert("Failure", "Failed to be inserted.", "Close");
                }
            }
        }
    }
}