using MyMangaReader.Models;

namespace MyMangaReader.Services.Interfaces
{
    public interface IGetSubscribedManga
    {
        public MangaModel GetSubscribedManga(int id);
    }
}
