using CommunityToolkit.Mvvm.ComponentModel;
using Lab1_MVVM.Models;

namespace Lab1_MVVM.ViewModels
{
    public partial class TwoWayBindingViewModel : ObservableObject
    {
        private UserModel _user = new();

        [ObservableProperty]
        private string _userName = "";

        [ObservableProperty]
        private int _userAge;

        [ObservableProperty]
        private string _feedback = "Измените имя или возраст";

        public TwoWayBindingViewModel()
        {
            UserName = _user.Name;
            UserAge = _user.Age;
        }
    }
}