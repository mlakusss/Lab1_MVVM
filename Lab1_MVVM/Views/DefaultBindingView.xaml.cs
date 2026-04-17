using System.Windows;
using Lab1_MVVM.Services;
using Lab1_MVVM.ViewModels;

namespace Lab1_MVVM.Views
{
    public partial class DefaultBindingView : System.Windows.Controls.UserControl
    {
        public DefaultBindingView() => InitializeComponent();

        private void UpdateStatus_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as DefaultBindingViewModel)?.UpdateStatus();
        }

        private void ShowMessage_Click(object sender, RoutedEventArgs e)
        {
            var loc = Application.Current.Resources["LocalizationService"] as Services.LocalizationService;
            MessageBox.Show(loc?["MessageBox_Text"]);
        }
    }
}