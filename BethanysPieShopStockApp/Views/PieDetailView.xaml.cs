using System;
using System.Collections.Generic;
using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.Views
{
    public partial class PieDetailView : ContentPage
    {
        public PieDetailView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.PieDetailViewModel;
        }
    }
}
