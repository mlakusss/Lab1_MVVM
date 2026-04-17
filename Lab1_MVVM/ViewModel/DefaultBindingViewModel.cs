using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lab1_MVVM.Models;

namespace Lab1_MVVM.ViewModels
{
    public partial class DefaultBindingViewModel : ObservableObject
    {
        private UserModel _user = new();

        [ObservableProperty]
        private string _userName = "";

        [ObservableProperty]
        private string _status = "Измените текст выше";

        public DefaultBindingViewModel()
        {
            UserName = _user.Name;
        }

        [RelayCommand]
        private void UpdateStatus()
        {
            Status = $"Имя изменено на '{UserName}' в {DateTime.Now:T}";
        }
    }
}