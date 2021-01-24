using System;
using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Utility;
using BethanysPieShopStockApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp
{
    public partial class App : Application
    {
        public static PieDataService PieDataService { get; } = new PieDataService();
        public static NavigationService NavigationService { get; } = new NavigationService();

        public App()
        {
            InitializeComponent();
            NavigationService.Configure(ViewNames.PieOverviewViews, typeof(PieOverviewView));
            NavigationService.Configure(ViewNames.PieDetailView, typeof(PieDetailView));
            MainPage = new NavigationPage(new PieOverviewView());
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
