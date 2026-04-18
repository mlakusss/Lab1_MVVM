using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace LocalizationLib
{
    public class LocalizationService : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static LocalizationService _instance;
        public static LocalizationService Instance => _instance ??= new LocalizationService();

        private CultureInfo _currentCulture;
        public CultureInfo CurrentCulture
        {
            get => _currentCulture;
            set
            {
                if (_currentCulture != value)
                {
                    _currentCulture = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
                }
            }
        }

        private Dictionary<string, Dictionary<string, string>> _translations;

        private LocalizationService()
        {
            LoadTranslations();
            CurrentCulture = new CultureInfo("ru-RU");
        }

        private void LoadTranslations()
        {
            _translations = new Dictionary<string, Dictionary<string, string>>();

            // Русский
            var ru = new Dictionary<string, string>
            {
                ["MainWindow_Title"] = "ЛР2 - Локализация (внешняя библиотека)",
                ["Tab1_Header"] = "Привязка по умолчанию",
                ["Tab2_Header"] = "Двухсторонняя привязка",
                ["Tab3_Header"] = "Одноразовая привязка",
                ["Tab4_Header"] = "Односторонние привязки",
                ["Tab5_Header"] = "Триггеры",
                ["Group_ViaVM"] = "Привязка через ViewModel",
                ["Direct_Group"] = "Прямая привязка к элементам (без VM)",
                ["Name_Label"] = "Имя:",
                ["Status_Label"] = "Статус (обновляется через кнопку):",
                ["Update_Button"] = "Обновить статус",
                ["Enter_Text"] = "Введите текст:",
                ["YouEntered"] = "Вы ввели:",
                ["Message_Button"] = "Показать сообщение",
                ["MessageBox_Text"] = "Привет, мир!",
                ["OneWay_DefaultNote"] = "*Mode=OneWay (по умолчанию для TextBlock)",

                ["TwoWay_Description"] = "Изменение данных в ViewModel автоматически обновляет UI",
                ["TwoWay_Name"] = "Имя (TwoWay):",
                ["TwoWay_Age"] = "Возраст (TwoWay):",
                ["TwoWay_Age_Label"] = "Возраст:",
                ["TwoWay_CurrentValues"] = "Текущие значения из ViewModel:",
                ["TwoWay_DirectGroup"] = "Прямая привязка к элементам (без ViewModel)",
                ["TwoWay_EnterText"] = "Введите текст в TextBox (TwoWay по умолчанию):",
                ["TwoWay_Content"] = "Содержимое TextBox (привязка OneWay):",
                ["TwoWay_Note"] = "*При вводе в полях 'Имя' или 'Возраст' значения ниже обновляются мгновенно (TwoWay)",

                ["OneTime_Header"] = "OneTime - значение устанавливается один раз при загрузке",
                ["OneTime_OneTimeLabel"] = "Привязка OneTime (не изменится):",
                ["OneTime_NormalLabel"] = "Обычная привязка (будет меняться):",
                ["OneTime_Button"] = "Обновить DynamicName",
                ["Explanation_Header"] = "Пояснение",
                ["OneTime_Explanation"] = "Mode=OneTime – значение считывается из источника (ViewModel) один раз при создании привязки и больше не обновляется, даже если источник изменится.\n\nНажмите кнопку: свойство DynamicName изменится (и отобразится в обычной привязке), но свойство InitialName с OneTime останется прежним.",

                ["OneWay_Description"] = "OneWay - данные идут только от источника к цели",
                ["OneWay_TextBoxLabel"] = "TextBox с привязкой OneWay (изменения в TextBox НЕ влияют на VM):",
                ["OneWay_VMValueLabel"] = "Значение в ViewModel (обновляется только из кода):",
                ["OneWay_Button"] = "Обновить SourceData в ViewModel",
                ["OneWay_Explanation"] = "Mode=OneWay – изменения в UI не отправляются обратно в ViewModel.\nПопробуйте изменить текст в жёлтом TextBox – ниже текст не изменится, так как привязка односторонняя.\nТолько нажатие кнопки (обновление свойства в коде) изменит отображение.",

                ["Triggers_Title"] = "Триггеры в WPF",
                ["Triggers_Property"] = "Property Trigger (реагирует на свойство UI)",
                ["Triggers_Property_Hover"] = "Наведи мышку на блок:",
                ["Triggers_Property_Text"] = "Наведи курсор сюда",
                ["Triggers_Data"] = "Data Trigger (реагирует на данные ViewModel)",
                ["Triggers_Data_Checkbox"] = "Включить выделение",
                ["Triggers_Data_Text"] = "Элемент с DataTrigger",
                ["Triggers_Event"] = "Event Trigger (анимация при событии)",
                ["Triggers_Event_Label"] = "Появление с анимацией при загрузке:",
                ["Triggers_Event_Text"] = "Я появился с анимацией!",
                ["Triggers_Note"] = "*Property Trigger – изменяет стиль при наведении мыши; Data Trigger – реагирует на свойство ViewModel; Event Trigger – запускает анимацию при событии Loaded"
            };

            // Английский
            var en = new Dictionary<string, string>
            {
                ["MainWindow_Title"] = "LR2 - Localization (external library)",
                ["Tab1_Header"] = "Default Binding",
                ["Tab2_Header"] = "TwoWay Binding",
                ["Tab3_Header"] = "OneTime Binding",
                ["Tab4_Header"] = "OneWay Bindings",
                ["Tab5_Header"] = "Triggers",
                ["Group_ViaVM"] = "Binding via ViewModel",
                ["Direct_Group"] = "Direct binding to UI (without VM)",
                ["Name_Label"] = "Name:",
                ["Status_Label"] = "Status (updated by button):",
                ["Update_Button"] = "Update status",
                ["Enter_Text"] = "Enter text:",
                ["YouEntered"] = "You entered:",
                ["Message_Button"] = "Show message",
                ["MessageBox_Text"] = "Hello, world!",
                ["OneWay_DefaultNote"] = "*Mode=OneWay (default for TextBlock)",

                ["TwoWay_Description"] = "Changing data in ViewModel automatically updates UI",
                ["TwoWay_Name"] = "Name (TwoWay):",
                ["TwoWay_Age"] = "Age (TwoWay):",
                ["TwoWay_Age_Label"] = "Age:",
                ["TwoWay_CurrentValues"] = "Current values from ViewModel:",
                ["TwoWay_DirectGroup"] = "Direct binding to UI (without ViewModel)",
                ["TwoWay_EnterText"] = "Enter text into TextBox (TwoWay by default):",
                ["TwoWay_Content"] = "TextBox content (OneWay binding):",
                ["TwoWay_Note"] = "*When typing in 'Name' or 'Age' fields, the values below update instantly (TwoWay)",

                ["OneTime_Header"] = "OneTime - value is set once at loading",
                ["OneTime_OneTimeLabel"] = "OneTime binding (won't change):",
                ["OneTime_NormalLabel"] = "Normal binding (will change):",
                ["OneTime_Button"] = "Update DynamicName",
                ["Explanation_Header"] = "Explanation",
                ["OneTime_Explanation"] = "Mode=OneTime – the value is read from the source (ViewModel) once when the binding is created and never updated again, even if the source changes.\n\nClick the button: DynamicName property will change (and be displayed in the normal binding), but InitialName with OneTime will remain the same.",

                ["OneWay_Description"] = "OneWay - data goes only from source to target",
                ["OneWay_TextBoxLabel"] = "TextBox with OneWay binding (changes in TextBox DO NOT affect VM):",
                ["OneWay_VMValueLabel"] = "Value in ViewModel (updated only from code):",
                ["OneWay_Button"] = "Update SourceData in ViewModel",
                ["OneWay_Explanation"] = "Mode=OneWay – changes in UI are not sent back to ViewModel.\nTry to change the text in the yellow TextBox – the text below will not change because the binding is one-way.\nOnly clicking the button (updating the property in code) will change the display.",

                ["Triggers_Title"] = "Triggers in WPF",
                ["Triggers_Property"] = "Property Trigger (reacts to UI property)",
                ["Triggers_Property_Hover"] = "Hover mouse over the block:",
                ["Triggers_Property_Text"] = "Hover here",
                ["Triggers_Data"] = "Data Trigger (reacts to ViewModel data)",
                ["Triggers_Data_Checkbox"] = "Enable highlight",
                ["Triggers_Data_Text"] = "Element with DataTrigger",
                ["Triggers_Event"] = "Event Trigger (animation on event)",
                ["Triggers_Event_Label"] = "Appear with animation on load:",
                ["Triggers_Event_Text"] = "I appeared with animation!",
                ["Triggers_Note"] = "*Property Trigger – changes style on mouse hover; Data Trigger – reacts to ViewModel property; Event Trigger – starts animation on Loaded event"
            };

            _translations["ru-RU"] = ru;
            _translations["en-US"] = en;
        }

        public void ChangeLanguage(string cultureName)
        {
            CurrentCulture = new CultureInfo(cultureName);
        }

        public string this[string key]
        {
            get
            {
                if (_translations.TryGetValue(CurrentCulture.Name, out var dict) && dict.TryGetValue(key, out var value))
                    return value;
                return key;
            }
        }
    }
}