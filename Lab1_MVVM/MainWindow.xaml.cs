using Lab1_MVVM.ViewModels;
using System.Windows;

namespace Lab1_MVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Назначаем DataContext для каждой вкладки
            var defaultVm = new DefaultBindingViewModel();
            var defaultView = (Views.DefaultBindingView)this.FindName("DefaultBindingView");
            if (defaultView != null) defaultView.DataContext = defaultVm;
        }
    }
}