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
    public partial class NewPage : ContentPage
    {
        public NewPage()
        {
            InitializeComponent();
            //lstView.ItemsSource = new List<string>()
            //{
            //    "abad","surat","sfa"
            //};
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Alert","Success","Ok");
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            images12.Rotation = value;


        }
    }
}