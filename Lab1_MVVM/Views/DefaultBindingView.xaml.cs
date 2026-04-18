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
                vm.UpdateStatus();
        }

        private void ShowMessage_Click(object sender, RoutedEventArgs e)
        {
            string msg = (string)Application.Current.FindResource("MessageBox_Text");
            MessageBox.Show(msg);
        }
    }
}