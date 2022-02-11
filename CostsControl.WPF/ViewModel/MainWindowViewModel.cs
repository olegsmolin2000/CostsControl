using CostsControl.WPF.ViewModel.Pages;
using Microsoft.Xaml.Behaviors.Core;
using System.Windows.Input;

namespace CostsControl.WPF.ViewModel
{
    internal class MainWindowViewModel : ViewModel
    {
        private ViewModel currentPage;
        public ViewModel CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;

                NotifyPropertyChanged(nameof(CurrentPage));
            }
        }

        public ICommand DisplayMainPage => new ActionCommand(action => CurrentPage = new MainPageViewModel());
        public ICommand DisplayProductsPage => new ActionCommand(action => CurrentPage = new ProductsPageViewModel());
    }
}