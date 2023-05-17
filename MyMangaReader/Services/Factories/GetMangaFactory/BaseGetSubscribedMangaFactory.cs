using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.Services.GetMangaFactory
{
    public abstract class BaseGetSubscribedMangaFactory
    {
        public abstract IGetSubscribedManga CreateInstance();
    }
}
