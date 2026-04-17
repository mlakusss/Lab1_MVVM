using Lab1_MVVM.Models;
using System;

namespace Lab1_MVVM.ViewModels
{
    public class OneTimeBindingViewModel : BaseViewModel
    {
        private UserModel _user = new UserModel();
        private string _initialName = "Начальное имя (не изменится)";
        public string InitialName
        {
            get => _initialName;
            set => SetProperty(ref _initialName, value);
        }

        private string _dynamicName = "Это имя будет меняться";
        public string DynamicName
        {
            get => _dynamicName;
            set => SetProperty(ref _dynamicName, value);
        }

        public OneTimeBindingViewModel()
        {
            _user.Name = "Иван Иванов";
            InitialName = _user.Name;
            DynamicName = _user.Name;
        }

        public void UpdateDynamicName()
        {
            DynamicName = $"Обновлено в {DateTime.Now:T}";
        }
    }
}