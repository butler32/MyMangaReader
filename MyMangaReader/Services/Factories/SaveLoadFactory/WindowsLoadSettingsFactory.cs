using MyMangaReader.Services.Interfaces;
using MyMangaReader.Services.SaveLoadSettings;

namespace MyMangaReader.Services.Factories.SaveLoadFactory
{
    public class WindowsLoadSettingsFactory : BaseLoadFactory
    {
        public override ILoadSettings LoadSettings()
        {
            return new WindowsLoadSettings();
        }
    }
}
