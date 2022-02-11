using CostsControl.WPF.ViewModel.Pages;
using System.Windows.Controls;

namespace CostsControl.WPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            DataContext = new MainPageViewModel();
        }
    }
}
