using LogistikFleetModel;
using LogistikFleetModel.AccessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogistikFleet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntialLoading : ContentPage
    {
        private ApiToken apiToken;
        private GetClientDetailsForMobileResponse getClientDetailsForMobile;
        string _token;
        bool IsUpdatesAvailable;
        string currentVersion;

        public IntialLoading()
        {
            InitializeComponent();

            if (!App.Current.Properties.ContainsKey("CustomerId"))
            {
                App.Current.Properties.Add("CustomerId", 0);
            }

            //if (!App.Current.Properties.ContainsKey("InquiryID"))
            //{
            //    App.Current.Properties.Add("InquiryID", 0);
            //}
            currentVersion = VersionTracking.CurrentVersion;
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var list = new List<SlidePageItems>
            {
               new SlidePageItems(){ id=0,label= "Welcome to our app. ",imageMobile="ms-appx:///miroshnichenko.mp4",imageTap="illu1.png",imageTapL="aSlide1s.gif",Skiplabel="Skip"},
                 new SlidePageItems(){ id=1,label="We are providing long term rentals. ",imageMobile="ms-appx:///luxury.mp4",imageTap="illu2.png",imageTapL="aSlide2s.gif", Skiplabel="Skip"},
                   new SlidePageItems(){ id=2,label= "Lower deposit, Lesser fees.  ",imageMobile="ms-appx:///Yacht.mp4",imageTap="illu3.png",imageTapL="aSlide3Ls.gif", Skiplabel="Next"}
            };
            TheCarousel.ItemsSource = list;

        }

        private void skipLabelTap_Tapped(object sender, EventArgs e)
        { 
            var obj = (Button)sender;
            SlidePageItems tappedPage = obj.BindingContext as SlidePageItems;
            if (tappedPage.id == 2)
            {
                Navigation.PushAsync(new LoginPage());
            }
            else
            {
                //TheCarousel.ScrollTo(2);
                Navigation.PushAsync(new LoginPage());
            }
        }
    }

    public class SlidePageItems
    {
        public int id { get; set; }
        public string label { get; set; }
        public string Skiplabel { get; set; }
        public string imageMobile { get; set; }
        public string imageTap { get; set; }
        public string imageTapL { get; set; }
    }
}