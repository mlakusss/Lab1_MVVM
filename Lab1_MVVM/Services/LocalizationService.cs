using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace Lab1_MVVM.Services
{
    public class LocalizationService : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static LocalizationService _instance;
        public static LocalizationService Instance => _instance ??= new LocalizationService();

        private CultureInfo _currentCulture;
        public CultureInfo CurrentCulture
        {
            get => _currentCulture;
            set
            {
                if (_currentCulture != value)
                {
                    _currentCulture = value;
                    Thread.CurrentThread.CurrentCulture = value;
                    Thread.CurrentThread.CurrentUICulture = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
                }
            }
        }

        public LocalizationService()
        {
            CurrentCulture = new CultureInfo("ru-RU");
        }

        public void ChangeLanguage(string cultureName)
        {
            CurrentCulture = new CultureInfo(cultureName);
        }

        public string this[string key]
        {
            get
            {
                var rm = new ResourceManager("Lab1_MVVM.Resources.Strings", typeof(LocalizationService).Assembly);
                string translation = rm.GetString(key, CurrentCulture);
                return translation ?? key;
            }
        }
    }
}