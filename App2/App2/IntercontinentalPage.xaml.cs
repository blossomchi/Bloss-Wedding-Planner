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
	public partial class IntercontinentalPage : ContentPage
	{
        public IList<CateringServices> cateringServices { get; set; }
        public IntercontinentalPage ()
		{
			InitializeComponent ();
            CouplesName.Text = "Welcome" + " " + App.SessionBrideName + " + " + App.SessionGroomName + " " + "To Intercontinental Services";
            SlideImage.Source = "intercon.jpg";

            cateringServices = new List<CateringServices>
            {
                new CateringServices() { CateringName = "CATERING SERVICES", CateringContact = "CONTACT DETAILS" },
                new CateringServices() { CateringName = "Bolafolu Foodfillment Limited", CateringContact = "Lagos Mainland " },
                new CateringServices() { CateringName = "Jaded Options Services ", CateringContact = "Lagos" },
                new CateringServices() { CateringName = "B&B Catering Services", CateringContact = "Lagos" },
                new CateringServices() { CateringName = "Florexcare Events", CateringContact = "Lagos" },
                new CateringServices() { CateringName = "Barn Events", CateringContact = "Lagos" },
                new CateringServices() { CateringName = "Eventbypops", CateringContact = "Lagos" },
                new CateringServices() { CateringName = "Cr8Ive Creations", CateringContact = "Lagos Mainland " },
                new CateringServices() { CateringName = "Glitz Events", CateringContact = "Lagos Mainland " },
                new CateringServices() { CateringName = "Amestclassy", CateringContact = "Lagos Mainland " },
                new CateringServices() { CateringName = "Ipel Ovens Limited", CateringContact = "Lagos Mainland " }
            };
            BindingContext = this;
        }

        public class CateringServices
        {
            public string CateringName { get; set; }
            public string CateringContact { get; set; }
        }

        private void Display_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Great", "Clicked Successfully.", "Close");
        }
    }
}