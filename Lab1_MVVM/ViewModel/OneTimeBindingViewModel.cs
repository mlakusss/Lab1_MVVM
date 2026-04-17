using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lab1_MVVM.Models;

namespace Lab1_MVVM.ViewModels
{
    public partial class OneTimeBindingViewModel : ObservableObject
    {
        private UserModel _user = new();

        [ObservableProperty]
        private string _initialName = "Начальное имя (не изменится)";

        [ObservableProperty]
        private string _dynamicName = "Это имя будет меняться";

        public OneTimeBindingViewModel()
        {
            _user.Name = "Иван Иванов";
            InitialName = _user.Name;
            DynamicName = _user.Name;
        }

        [RelayCommand]
        private void UpdateDynamicName()
        {
            DynamicName = $"Обновлено в {DateTime.Now:T}";
        }
    }
}