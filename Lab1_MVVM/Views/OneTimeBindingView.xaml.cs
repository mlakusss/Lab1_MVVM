using System.Windows;
using Lab1_MVVM.ViewModels;

namespace Lab1_MVVM.Views
{
    public partial class OneTimeBindingView : System.Windows.Controls.UserControl
    {
        public OneTimeBindingView()
        {
            InitializeComponent();
        }

        private void UpdateDynamicName_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as OneTimeBindingViewModel)?.UpdateDynamicName();
        }
    }
}