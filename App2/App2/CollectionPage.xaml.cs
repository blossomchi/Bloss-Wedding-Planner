using App2.Model;
using SQLite;
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
	public partial class CollectionPage : ContentPage
	{
        public string NewBrideName;
        public string NewGroomName;
        public DateTime WeddingDate;
        public int CouplesID;
        public CollectionPage ()
		{
			InitializeComponent ();
            CollectionName.Text = "Welcome" + " " + App.SessionBrideName + " & " + App.SessionGroomName + " " + "To Collection Page";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
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

                var SeatInfo =  (from mas in db.Table<RegisterTable>()
                                join det in db.Table<SeatsTable>()
                                on mas.CusID equals det.RegisterCusID
                                where det.RegisterCusID == CouplesID
                                select det).ToList();

                SeatsInfo.ItemsSource = SeatInfo;
            }
        }
    }
}