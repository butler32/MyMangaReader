using MyMangaReader.Models;
using MyMangaReader.Services.Interfaces;
using HtmlAgilityPack;

namespace MyMangaReader.Services.GetManga
{
    public class GetMangaLibSubscribedManga : IGetSubscribedManga
    {
        private MangaModel _manga;
        
        public MangaModel GetSubscribedManga(int id)
        {
            var url = "https://mangalib.me/manga-list";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var divElement = doc.DocumentNode.SelectSingleNode($"//a[@data-media-id='{id}']");

            if (divElement != null)
            {
                var link = divElement.Attributes["href"].Value;
                doc = web.Load(link);

            }

            return _manga;
        }
    }
}
