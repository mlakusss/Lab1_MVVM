namespace Lab1_MVVM.ViewModels
{
    public class OneWayBindingViewModel : BaseViewModel
    {
        private string _sourceData = "Начальные данные из VM";
        public string SourceData
        {
            get => _sourceData;
            set => SetProperty(ref _sourceData, value);
        }

        public void UpdateSource()
        {
            SourceData = $"Обновлено в {DateTime.Now:T}";
        }
    }
}