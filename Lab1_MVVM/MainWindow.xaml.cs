using System.Windows;
using System.Windows.Controls;
using Lab1_MVVM.Services;

namespace Lab1_MVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb && cb.SelectedItem is ComboBoxItem item && item.Tag is string lang)
            {
                LocalizationHelper.ChangeLanguage(lang);
            }
        }
    }
}