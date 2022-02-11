using CostsControl.WPF.ViewModel.Pages;
using System.Windows.Controls;

namespace CostsControl.WPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : UserControl
    {
        public ProductsPage()
        {
            InitializeComponent();

            DataContext = new ProductsPageViewModel();
        }
    }
}
