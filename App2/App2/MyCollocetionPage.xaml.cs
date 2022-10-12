using System;
using App2.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCollocetionPage : ContentPage
	{
        public string NewBrideName;
        public string NewGroomName;
        public DateTime WeddingDate;
        public int CouplesID;
        public MyCollocetionPage ()
		{
			InitializeComponent ();
            CollectionName.Text = "Welcome" + " " + App.SessionBrideName + " & " + App.SessionGroomName + " " + "To Collection Page";
            //VenueInfo.IsEnabled = false;
            //WedInfo.IsEnabled = true;
        }

        private void WedInfo_Clicked(object sender, EventArgs e)
        {

            NewBrideName = App.SessionBrideName;
            NewGroomName = App.SessionGroomName;
            WeddingDate = App.SessionWeddingDate;


            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<RegisterTable>();
                conn.CreateTable<SeatsTable>();

                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var data = db.Table<RegisterTable>().ToList();  //Call Table
                var data1 = data.Where(x => x.BrideName == NewBrideName && x.GroomName == NewGroomName && x.WeddingDate == WeddingDate).ToList(); //Linq Query  

                CouplesID = data.Where(x => x.BrideName == NewBrideName && x.GroomName == NewGroomName && x.WeddingDate == WeddingDate).SingleOrDefault().CusID; //Linq Query                

                BrideInfo.ItemsSource = data1;
                BrideInfo.IsVisible = true;
                SeatsInfo.IsVisible = false;
                VenueInfo.IsEnabled = true;
                WedInfo.IsEnabled = false;
                

            }
        }

        private void VenueInfo_Clicked(object sender, EventArgs e)
        {

            NewBrideName = App.SessionBrideName;
            NewGroomName = App.SessionGroomName;
            WeddingDate = App.SessionWeddingDate;


            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<RegisterTable>();
                conn.CreateTable<SeatsTable>();

                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var data = db.Table<RegisterTable>().ToList();  //Call Table
                //var data1 = data.Where(x => x.BrideName == NewBrideName && x.GroomName == NewGroomName && x.WeddingDate == WeddingDate).ToList(); //Linq Query  

                CouplesID = data.Where(x => x.BrideName == NewBrideName && x.GroomName == NewGroomName && x.WeddingDate == WeddingDate).SingleOrDefault().CusID; //Linq Query                

                //BrideInfo.ItemsSource = data1;

                var SeatInfo = (from mas in db.Table<RegisterTable>()
                                join det in db.Table<SeatsTable>()
                                on mas.CusID equals det.RegisterCusID
                                where det.RegisterCusID == CouplesID
                                select det).ToList();

                SeatsInfo.ItemsSource = SeatInfo;
                BrideInfo.IsVisible = false;
                SeatsInfo.IsVisible = true;
                VenueInfo.IsEnabled = false;
                WedInfo.IsEnabled = true;
            }
        }
    }
}