using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.Services.Factories.GetMangaFactory
{
    public abstract class BaseSearchMangaFactory
    {
        public abstract ISearchManga CreateInstance();
    }
}
