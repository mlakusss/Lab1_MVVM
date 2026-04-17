using Lab1_MVVM.ViewModels;
using System.Windows;
using System.Windows.Controls;

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
        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb && cb.SelectedItem is ComboBoxItem item && item.Tag is string cultureTag)
            {
                // Прямой вызов синглтона – не требует ресурса
                Services.LocalizationService.Instance.ChangeLanguage(cultureTag);
            }
        }
    }
}