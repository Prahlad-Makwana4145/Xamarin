using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TraineeDemoApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1CarouselPage : CarouselPage
    {
        public Page1CarouselPage()
        {
            InitializeComponent();
        }

        private void Click_ME(object sender, EventArgs e)
        {
            App.Current.MainPage = new MenuPage();
        }
    }
}