using Lab1_MVVM.Models;
using System;

namespace Lab1_MVVM.ViewModels
{
    public class DefaultBindingViewModel : BaseViewModel
    {
        private UserModel _user = new UserModel();
        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    _user.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _status = "Измените текст выше";
        public string Status
        {
            get => _status;
            set => SetProperty(ref _status, value);
        }

        public DefaultBindingViewModel()
        {
            UserName = _user.Name;
        }

        public void UpdateStatus()
        {
            Status = $"Имя изменено на '{UserName}' в {DateTime.Now:T}";
        }
    }
}