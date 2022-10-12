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
	public partial class DashPage : ContentPage
	{
		public DashPage ()
		{
			InitializeComponent ();
            CouplesNameEntry.Text ="Welcome" + " " + App.SessionBrideName + " + " + App.SessionGroomName + " " + "To Dashboard";
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void FoodBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodDrinksPage());
        }

        private void ListBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListPage());
        }

        private void BudgetBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BudgetPage());
        }

        private void SeatBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SeatPage());
        }

        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyCollocetionPage());
        }
    }
}