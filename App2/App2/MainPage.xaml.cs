using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            imgDisp.Source = "Sal.png";
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
           Navigation.PushAsync(new NextInfoPage());
        }

        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}
