using System.Windows;
using Lab1_MVVM.ViewModels;

namespace Lab1_MVVM.Views
{
    public partial class OneWayBindingView : System.Windows.Controls.UserControl
    {
        public OneWayBindingView()
        {
            InitializeComponent();
        }

        private void UpdateSource_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is OneWayBindingViewModel vm)
                vm.UpdateSource();
        }
    }
}