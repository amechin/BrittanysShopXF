using System;
using System.Collections.Generic;
using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.Views
{
    public partial class PieOverviewView : ContentPage
    {
        public PieOverviewView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.PieOverviewViewModel;
        }
    }
}
