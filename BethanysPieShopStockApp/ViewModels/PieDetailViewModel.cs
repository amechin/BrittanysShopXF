using System;
using System.Windows.Input;
using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Utility;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailViewModel: BaseViewModel
    {
        private Pie _selectedPie;

        public ICommand SaveCommand { get; }

        public Pie SelectedPie
        {
            get => _selectedPie;
            set
            {
                _selectedPie = value;
                OnPropertyChanged("SelectedPie");
            }
        }

        public PieDetailViewModel()
        {
            SelectedPie = new Pie();
            SaveCommand = new Command(OnSaveCommand);
        }

        public void OnSaveCommand()
        {
            if (SelectedPie.Id == Guid.Empty)
                App.PieDataService.AddPie(SelectedPie);
            else
                App.PieDataService.UpdatePie(SelectedPie);

            MessagingCenter.Send(this, MessageNames.PieChangedMessage, SelectedPie);

            App.NavigationService.GoBack();


        }

        public override void Initialize(object parameter)
        {
            if (parameter == null) SelectedPie = new Pie();
            else SelectedPie = parameter as Pie;
        }
    }
}
