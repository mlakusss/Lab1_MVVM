namespace Lab1_MVVM.ViewModels
{
    public class TriggersViewModel : BaseViewModel
    {
        private bool _isHighlighted;
        public bool IsHighlighted { get => _isHighlighted; set => SetProperty(ref _isHighlighted, value); }
    }
}