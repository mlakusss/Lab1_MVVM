using System.Windows;
using Lab1_MVVM.ViewModels;

namespace Lab1_MVVM.Views
{
    public partial class DefaultBindingView : System.Windows.Controls.UserControl
    {
        public DefaultBindingView()
        {
            InitializeComponent();
        }

        private void UpdateStatus_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is DefaultBindingViewModel vm)
            {
                vm.Status = $"Имя изменено на '{vm.UserName}' в {DateTime.Now:T}";
            }
        }
    }
}