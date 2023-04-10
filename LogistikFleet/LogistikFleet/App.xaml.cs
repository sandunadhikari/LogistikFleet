using LogistikFleet.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using LogistikFleetModel;
using LogistikFleetModel.AccessModels;

namespace LogistikFleet
{
    public partial class App : Xamarin.Forms.Application
    {
        private ApiToken apiToken;
        private GetClientDetailsForMobileResponse getClientDetailsForMobile;

        public App()
        {
            Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
            Xamarin.Forms.Device.SetFlags(new string[] { "MediaElement_Experimental", "Brush_Experimental", "SwipeView_Experimental" });
            InitializeComponent();

            //var currentVersion = VersionTracking.CurrentVersion;

            if (!App.Current.Properties.ContainsKey("IsOnborded"))
            {
                App.Current.Properties.Add("IsOnborded", false);
            }


            MainPage = new NavigationPage(new Productor());


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
