using System.Windows;
using Lab1_MVVM.Services;

namespace Lab1_MVVM
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Application.Current.Resources.Add("LocalizationService", Services.LocalizationService.Instance);
        }
    }
}