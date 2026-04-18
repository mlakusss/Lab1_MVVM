using System.Windows;

namespace Lab1_MVVM.Services
{
    public static class LocalizationHelper
    {
        public static void ChangeLanguage(string cultureCode)
        {
            var dict = new ResourceDictionary();
            switch (cultureCode)
            {
                case "en":
                    dict.Source = new Uri("/Resources/Lang.en.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("/Resources/Lang.ru.xaml", UriKind.Relative);
                    break;
            }
            // Очищаем существующие словари и добавляем новый
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }
    }
}