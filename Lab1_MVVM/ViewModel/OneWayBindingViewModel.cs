using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Lab1_MVVM.ViewModels
{
    public partial class OneWayBindingViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _sourceData = "Начальные данные из VM";

        [RelayCommand]
        private void UpdateSource()
        {
            SourceData = $"Обновлено в {DateTime.Now:T}";
        }
    }
}