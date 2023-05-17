using MyMangaReader.Services.Factories.SaveLoadFactory;
using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.ViewModels
{
    public class GetSettingsViewModel : BaseViewModel
    {
        private string data;

        public string Data
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged();
            }
        }

        private readonly BaseLoadFactory _loadFactory;

        public GetSettingsViewModel()
        {
            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                _loadFactory = new IOSLoadSettingsFactory();
            }
            else if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                _loadFactory = new AndroidLoadSettingsFactory();
            }
            else
            {
                _loadFactory = new WindowsLoadSettingsFactory();
            }
        }
        
        public string GetSettings()
        {
            ILoadSettings loadSettingsInstance = _loadFactory.LoadSettings();

            return loadSettingsInstance.LoadSettings();
        }
    }
}
