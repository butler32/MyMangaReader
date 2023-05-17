using MyMangaReader.Services.GetManga;
using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.Services.GetMangaFactory
{
    public class GetMangaLibSubscribedMangaFactory : BaseGetSubscribedMangaFactory
    {
        public override IGetSubscribedManga CreateInstance()
        {
            return new GetMangaLibSubscribedManga();
        }
    }
}
