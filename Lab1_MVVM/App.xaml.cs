using System.Windows;
using LocalizationLib;

namespace Lab1_MVVM
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Application.Current.Resources.Add("LocalizationService", LocalizationLib.LocalizationService.Instance);
        }
    }
}