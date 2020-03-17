using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TraineeDemoApplication
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int startX;
        public MainPage()
        {
            InitializeComponent();
        }

        //private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    text = ((Entry)sender).Text;

        //}

        //private void Entry_Completed(object sender, EventArgs e)
        //{
        //    text = ((Entry)sender).Text;
        //}

        //private void Handle_Tapped(object sender, EventArgs e)
        //{

        //}

        private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {

                case GestureStatus.Started:
                    imgbox.TranslationX = e.TotalX;
                    break;

                case GestureStatus.Running:
                    imgbox.TranslationX = e.TotalX;
                    if (e.TotalX <= -100)
                    {
                        abcbg.BackgroundColor = Color.Red;
                        imgbox.TranslationX = 0;
                        break;
                    }
                    else if (e.TotalX >= 100)
                    {
                        abcbg.BackgroundColor = Color.Blue;
                        imgbox.TranslationX = 0;
                        break;
                    }
                    break;

                case GestureStatus.Completed:
                    imgbox.TranslationX = e.TotalX;
                    break;
            }
        }
    }
}
