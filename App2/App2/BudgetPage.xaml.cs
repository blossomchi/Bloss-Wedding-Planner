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
	public partial class BudgetPage : ContentPage
	{
        public decimal amount;
        public decimal recp;
        public decimal phot;
        public decimal flo;
        public decimal mus;
        public decimal holt;
        public decimal stati;
        public decimal dres;
        public decimal gif;
        public decimal ring;
        public decimal acess;
        public decimal bea;
        public decimal menswr;
        public int CouplesID;
        public string BrideName;
        public string GroomName;
        public DateTime WeddingDate;

        public BudgetPage ()
		{
			InitializeComponent ();

            BrideName = App.SessionBrideName;
            GroomName = App.SessionGroomName;
            WeddingDate = App.SessionWeddingDate;

            if (BrideName == null && GroomName == null && WeddingDate == null)
            { Navigation.PushAsync(new LoginPage()); }

            //get couples id
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
            var db = new SQLite.SQLiteConnection(dpPath);
            var data = db.Table<RegisterTable>();  //Call Table  
            var data1 = data.Where(x => x.BrideName == BrideName && x.GroomName == GroomName && x.WeddingDate == WeddingDate).SingleOrDefault().CusID; //Linq Query  

            CouplesID = data1;
        }

        private void BudgetBtn_Clicked(object sender, EventArgs e)
        {
            amount = Convert.ToDecimal(BudgetEntry.Text);
            //if (amount)
            //{

            //} 
            if(amount == 0)
            {
                DisplayAlert("Sorry", "You cannot plan with 0 amount.", "Close");
            }
            else
            {
                string lengAmount = Convert.ToString(amount).Length.ToString();
                if (Convert.ToDecimal(lengAmount) == 6  && amount <= 900000 && amount >= 500000)
                {
                    recp = 30000;
                    phot = 15000;
                    flo = 10000;
                    mus = 7000;
                    holt = 5000;
                    stati = 3000;
                    dres = 30000;
                    gif = 20000;
                    ring = 6000;
                    acess = 15000;
                    bea = 30000;

                    Reception.Text = "Reception" + " = " + " " + " " + "N" + recp;
                    Reception.IsVisible = true;
                    PhotoVi.Text = "Photo + Video" + " = " + " " + " " + "N" + phot;
                    PhotoVi.IsVisible = true;
                    flower.Text = "Flowers" + " = " + " " + " " + "N" + flo;
                    flower.IsVisible = true;
                    music.Text = "Music" + " = " + " " + " " + "N" + mus;
                    music.IsVisible = true;
                    hotelTra.Text = "Hotel + Transportation" + " = " + " " + " " + "N" + holt;
                    hotelTra.IsVisible = true;
                    stationary.Text = "Stationery" + " = " + " " + " " + "N" + stati;
                    stationary.IsVisible = true;
                    dress.Text = "Dress" + " = " + " " + " " + "N" + dres;
                    dress.IsVisible = true;
                    gift.Text = "Gifts" + " = " + " " + " " + "N" + gif;
                    gift.IsVisible = true;
                    rings.Text = "Rings" + " = " + " " + " " + "N" + ring;
                    rings.IsVisible = true;
                    accessories.Text = "Accessories" + " = " + " " + " " + "N" + acess;
                    accessories.IsVisible = true;
                    beauty.Text = "Beauty" + " = " + " " + " " + "N" + bea;
                    beauty.IsVisible = true;
                }
                
                if (Convert.ToDecimal(lengAmount) == 6 && amount <= 400000 && amount >= 100000)
                {
                    recp = 20000;
                    phot = 15000;
                    flo = 10000;
                    mus = 7000;
                    holt = 5000;
                    stati = 3000;
                    dres = 100000;
                    gif = 23000;
                    ring = 5000;
                    acess = 2000;
                    bea = 10000;

                    Reception.Text = "Reception" + " = " + " " + " " + "N" + recp;
                    Reception.IsVisible = true;
                    PhotoVi.Text = "Photo + Video" + " = " + " " + " " + "N" + phot;
                    PhotoVi.IsVisible = true;
                    flower.Text = "Flowers" + " = " + " " + " " + "N" + flo;
                    flower.IsVisible = true;
                    music.Text = "Music" + " = " + " " + " " + "N" + mus;
                    music.IsVisible = true;
                    hotelTra.Text = "Hotel + Transportation" + " = " + " " + " " + "N" + holt;
                    hotelTra.IsVisible = true;
                    stationary.Text = "Stationery" + " = " + " " + " " + "N" + stati;
                    stationary.IsVisible = true;
                    dress.Text = "Dress" + " = " + " " + " " + "N" + dres;
                    dress.IsVisible = true;
                    gift.Text = "Gifts" + " = " + " " + " " + "N" + gif;
                    gift.IsVisible = true;
                    rings.Text = "Rings" + " = " + " " + " " + "N" + ring;
                    rings.IsVisible = true;
                    accessories.Text = "Accessories" + " = " + " " + " " + "N" + acess;
                    accessories.IsVisible = true;
                    beauty.Text = "Beauty" + " = " + " " + " " + "N" + bea;
                    beauty.IsVisible = true;
                }

                if (Convert.ToDecimal(lengAmount) == 5 && amount <= 90000 && amount >= 50000)
                {
                    recp = 20000;
                    phot = 1500;
                    flo = 5000;
                    mus = 7000;
                    holt = 5000;
                    stati = 3000;
                    dres = 20000;
                    gif = 1000;
                    ring = 1000;
                    acess = 1500;
                    bea = 2500;

                    Reception.Text = "Reception" + " = " + " " + " " + "N" + recp;
                    Reception.IsVisible = true;
                    PhotoVi.Text = "Photo + Video" + " = " + " " + " " + "N" + phot;
                    PhotoVi.IsVisible = true;
                    flower.Text = "Flowers" + " = " + " " + " " + "N" + flo;
                    flower.IsVisible = true;
                    music.Text = "Music" + " = " + " " + " " + "N" + mus;
                    music.IsVisible = true;
                    hotelTra.Text = "Hotel + Transportation" + " = " + " " + " " + "N" + holt;
                    hotelTra.IsVisible = true;
                    stationary.Text = "Stationery" + " = " + " " + " " + "N" + stati;
                    stationary.IsVisible = true;
                    dress.Text = "Dress" + " = " + " " + " " + "N" + dres;
                    dress.IsVisible = true;
                    gift.Text = "Gifts" + " = " + " " + " " + "N" + gif;
                    gift.IsVisible = true;
                    rings.Text = "Rings" + " = " + " " + " " + "N" + ring;
                    rings.IsVisible = true;
                    accessories.Text = "Accessories" + " = " + " " + " " + "N" + acess;
                    accessories.IsVisible = true;
                    beauty.Text = "Beauty" + " = " + " " + " " + "N" + bea;
                    beauty.IsVisible = true;
                }

                if (Convert.ToDecimal(lengAmount) == 5 && amount <= 40000 && amount >= 10000)
                {
                    recp = 20000;
                    phot = 15000;
                    flo = 5000;
                    mus = 7000;
                    holt = 5000;
                    stati = 3000;
                    dres = 10000;
                    gif = 1000;
                    ring = 1000;
                    acess = 1500;
                    bea = 1500;

                    Reception.Text = "Reception" + " = " + " " + " " + "N" + recp;
                    Reception.IsVisible = true;
                    PhotoVi.Text = "Photo + Video" + " = " + " " + " " + "N" + phot;
                    PhotoVi.IsVisible = true;
                    flower.Text = "Flowers" + " = " + " " + " " + "N" + flo;
                    flower.IsVisible = true;
                    music.Text = "Music" + " = " + " " + " " + "N" + mus;
                    music.IsVisible = true;
                    hotelTra.Text = "Hotel + Transportation" + " = " + " " + " " + "N" + holt;
                    hotelTra.IsVisible = true;
                    stationary.Text = "Stationery" + " = " + " " + " " + "N" + stati;
                    stationary.IsVisible = true;
                    dress.Text = "Dress" + " = " + " " + " " + "N" + dres;
                    dress.IsVisible = true;
                    gift.Text = "Gifts" + " = " + " " + " " + "N" + gif;
                    gift.IsVisible = true;
                    rings.Text = "Rings" + " = " + " " + " " + "N" + ring;
                    rings.IsVisible = true;
                    accessories.Text = "Accessories" + " = " + " " + " " + "N" + acess;
                    accessories.IsVisible = true;
                    beauty.Text = "Beauty" + " = " + " " + " " + "N" + bea;
                    beauty.IsVisible = true;
                }

                if (Convert.ToDecimal(lengAmount) == 4 && amount <= 9000 && amount >= 6000)
                {
                    recp = 2000;
                    phot = 500;
                    flo = 100;
                    mus = 700;
                    holt = 100;
                    stati = 100;
                    dres = 1000;
                    gif = 100;
                    ring = 100;
                    acess = 150;
                    bea = 150;

                    Reception.Text = "Reception" + " = " + " " + " " + "N" + recp;
                    Reception.IsVisible = true;
                    PhotoVi.Text = "Photo + Video" + " = " + " " + " " + "N" + phot;
                    PhotoVi.IsVisible = true;
                    flower.Text = "Flowers" + " = " + " " + " " + "N" + flo;
                    flower.IsVisible = true;
                    music.Text = "Music" + " = " + " " + " " + "N" + mus;
                    music.IsVisible = true;
                    hotelTra.Text = "Hotel + Transportation" + " = " + " " + " " + "N" + holt;
                    hotelTra.IsVisible = true;
                    stationary.Text = "Stationery" + " = " + " " + " " + "N" + stati;
                    stationary.IsVisible = true;
                    dress.Text = "Dress" + " = " + " " + " " + "N" + dres;
                    dress.IsVisible = true;
                    gift.Text = "Gifts" + " = " + " " + " " + "N" + gif;
                    gift.IsVisible = true;
                    rings.Text = "Rings" + " = " + " " + " " + "N" + ring;
                    rings.IsVisible = true;
                    accessories.Text = "Accessories" + " = " + " " + " " + "N" + acess;
                    accessories.IsVisible = true;
                    beauty.Text = "Beauty" + " = " + " " + " " + "N" + bea;
                    beauty.IsVisible = true;
                }

                if (Convert.ToDecimal(lengAmount) < 4 && amount < 5000)
                {
                    recp = 0;
                    phot = 0;
                    flo = 0;
                    mus = 0;
                    holt = 0;
                    stati = 0;
                    dres = 0;
                    gif = 0;
                    ring = 0;
                    acess = 0;
                    bea = 0;

                    Reception.Text = "Reception" + " = " + " " + " " + "N" + recp;
                    Reception.IsVisible = true;
                    PhotoVi.Text = "Photo + Video" + " = " + " " + " " + "N" + phot;
                    PhotoVi.IsVisible = true;
                    flower.Text = "Flowers" + " = " + " " + " " + "N" + flo;
                    flower.IsVisible = true;
                    music.Text = "Music" + " = " + " " + " " + "N" + mus;
                    music.IsVisible = true;
                    hotelTra.Text = "Hotel + Transportation" + " = " + " " + " " + "N" + holt;
                    hotelTra.IsVisible = true;
                    stationary.Text = "Stationery" + " = " + " " + " " + "N" + stati;
                    stationary.IsVisible = true;
                    dress.Text = "Dress" + " = " + " " + " " + "N" + dres;
                    dress.IsVisible = true;
                    gift.Text = "Gifts" + " = " + " " + " " + "N" + gif;
                    gift.IsVisible = true;
                    rings.Text = "Rings" + " = " + " " + " " + "N" + ring;
                    rings.IsVisible = true;
                    accessories.Text = "Accessories" + " = " + " " + " " + "N" + acess;
                    accessories.IsVisible = true;
                    beauty.Text = "Beauty" + " = " + " " + " " + "N" + bea;
                    beauty.IsVisible = true;

                    DisplayAlert("Sorry", "You cannot plan with this amount.", "Close");
                }

             }
        }

        private void BudgetEnterBtn_Clicked(object sender, EventArgs e)
        {

            BudgetTable budgetTable = new BudgetTable()
            {
                BudgetName = BudgetNameEntry.Text,
                BudgetAmount = Convert.ToDecimal(BudgetEntry.Text),
                RegisterCusID = CouplesID
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<BudgetTable>();
                //conn.CreateTable<BudgetTable>();

                //check if budget already exist
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "WeddPlanner_db.sqlite"); //Call Database  
                var db = new SQLite.SQLiteConnection(dpPath);
                var dataBudget = db.Table<BudgetTable>();  //Call Table  
                var checkExist = dataBudget.Where(x => x.BudgetName == BudgetNameEntry.Text && x.RegisterCusID == CouplesID).Any(); //Linq Query  

                if (checkExist)
                {
                    DisplayAlert("Great", "Budget has already been added.", "Close");
                }
                else
                {
                    if (Convert.ToDecimal(BudgetEntry.Text) > Convert.ToDecimal(BudgetOveralEntry.Text))
                    {
                        DisplayAlert("Great", "Item amount cannot be greater than overall Budget .", "Close");
                    }
                    else
                    {
                        var numberRow = conn.Insert(budgetTable); //insert into the table

                        if (numberRow > 0) //check if it was inserted
                            DisplayAlert("Great", "Budget was saved successfully.", "Close");
                        else
                            DisplayAlert("Failure", "Failed to be inserted.", "Close");

                        var BugInfo = (from mas in db.Table<RegisterTable>()
                                       join det in db.Table<BudgetTable>()
                                       on mas.CusID equals det.RegisterCusID
                                       where det.RegisterCusID == CouplesID
                                       select det).ToList();

                        BudgetView.ItemsSource = BugInfo;
                        // get all the amount from the budget table
                        BudgetNameEntry.Text = "";
                        BudgetEntry.Text = "";
                    }
                 }
            }
        }
    }
}