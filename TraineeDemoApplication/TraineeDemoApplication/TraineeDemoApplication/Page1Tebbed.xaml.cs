using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace TraineeDemoApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1Tebbed : Xamarin.Forms.TabbedPage
    {
        public Page1Tebbed()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MenuPage();
        }

    }
}