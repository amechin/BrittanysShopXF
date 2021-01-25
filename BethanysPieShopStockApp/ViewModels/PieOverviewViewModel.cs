using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieOverviewViewModel: BaseViewModel
    {
        private ObservableCollection<Pie> _pies;

        public ICommand LoadCommand { get; }

        public ICommand AddCommand { get; }

        public ICommand PieSelectedCommand { get; }

        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                OnPropertyChanged("Pies");
            }
        }

        public PieOverviewViewModel()
        {
            Pies = new ObservableCollection<Pie>();

            LoadCommand = new Command(OnLoadCommand);
            AddCommand = new Command(OnAddCommand);
            PieSelectedCommand = new Command<Pie>(OnPieSelectedCommand);

            MessagingCenter.Subscribe<PieDetailViewModel, Pie>
                (this, MessageNames.PieChangedMessage, OnPieChanged);
        }

        public void OnPieChanged(PieDetailViewModel sender, Pie pie)
        {
            Pies = new ObservableCollection<Pie>(App.PieDataService.GetAllPies());
        }

        public void OnPieSelectedCommand(Pie pie)
        {
            App.NavigationService.NavigateTo(ViewNames.PieDetailView, pie);
        }

        public void OnLoadCommand()
        {
            //Pies = new ObservableCollection<Pie>(PieRepository.Pies);
            Pies = new ObservableCollection<Pie>(App.PieDataService.GetAllPies());
        }

        public void OnAddCommand()
        {
            App.NavigationService.NavigateTo(ViewNames.PieDetailView);
        }
    }
}
