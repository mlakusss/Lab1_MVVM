using CommunityToolkit.Mvvm.ComponentModel;

namespace Lab1_MVVM.ViewModels
{
    public partial class TriggersViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isHighlighted;
    }
}