﻿//using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace LogistikFleet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : Xamarin.Forms.TabbedPage
    {
        [Obsolete]
        public HomeTabbedPage()
        {
            InitializeComponent();

            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom)
             .SetBarItemColor(Xamarin.Forms.Application.Current.RequestedTheme == OSAppTheme.Dark ? Color.Gray : Color.Black)
             .SetBarSelectedItemColor(Xamarin.Forms.Application.Current.RequestedTheme == OSAppTheme.Dark ? Color.FromHex("#c00210") : Color.FromHex("#c00210"))
             .SetIsSwipePagingEnabled(false);

            this.SelectedItem = Dashboard;

        }

        [Obsolete]
        protected override void OnAppearing()
        {
            base.OnAppearing();
            On<Android>().SetBarItemColor(Xamarin.Forms.Application.Current.RequestedTheme == OSAppTheme.Dark ? Color.Gray : Color.Black)
                 .SetBarSelectedItemColor(Xamarin.Forms.Application.Current.RequestedTheme == OSAppTheme.Dark ? Color.FromHex("#c00210") : Color.FromHex("#c00210"));

            this.SelectedItem = Dashboard;
        }
    }
}
