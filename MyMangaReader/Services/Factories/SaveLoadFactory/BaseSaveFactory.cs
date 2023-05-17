using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.Services.Factories.SaveLoadFactory
{
    public abstract class BaseSaveFactory
    {
        public abstract ISaveSettings SaveSettings();
    }
}
