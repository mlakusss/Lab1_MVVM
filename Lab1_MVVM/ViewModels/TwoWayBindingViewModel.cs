using Lab1_MVVM.Models;

namespace Lab1_MVVM.ViewModels
{
    public class TwoWayBindingViewModel : BaseViewModel
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

        private int _userAge;
        public int UserAge
        {
            get => _userAge;
            set
            {
                if (_userAge != value)
                {
                    _userAge = value;
                    _user.Age = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _feedback = "Измените имя или возраст";
        public string Feedback
        {
            get => _feedback;
            set => SetProperty(ref _feedback, value);
        }

        public TwoWayBindingViewModel()
        {
            UserName = _user.Name;
            UserAge = _user.Age;
        }
    }
}