using MyMangaReader.Services.Interfaces;
using MyMangaReader.Services.SaveLoadSettings;

namespace MyMangaReader.Services.Factories.SaveLoadFactory
{
    public class IOSSaveSettingsFactory : BaseSaveFactory
    {
        public override ISaveSettings SaveSettings()
        {
            return new IOSSaveSettings();
        }
    }
}
