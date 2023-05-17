using HtmlAgilityPack;
using System.Text;
using MyMangaReader.Models;
using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.Services.GetManga
{
    public class SearchMangaLibManga : ISearchManga
    {
        private MangaModel _newManga;
        public ICollection<MangaModel> SearchManga(string name)
        {
            List<MangaModel> _mangas = new List<MangaModel>();
            var splitName = name.Split(' ');
            StringBuilder urlBuilder = new StringBuilder();
            urlBuilder.Append("https://mangalib.me/manga-list?name=");

            for(int i = 0; i < splitName.Length; i++)
            {
                if (i != 0)
                {
                    urlBuilder.Append("%20");
                }

                urlBuilder.Append(splitName[i]);
            }

            var url = urlBuilder.ToString();
            var web = new HtmlWeb();
            var searchDoc = web.Load(url);
            var searchDiv = searchDoc.DocumentNode.SelectSingleNode($"//div[@class='media-cards-grid']");

            if (searchDiv != null)
            {
                var links = searchDiv.SelectNodes(".//a[@href]");

                if (links != null)
                {
                    foreach (var link in links)
                    {
                        _newManga = new MangaModel();
                        _newManga.Name = link.Attributes["href"].Value;
                        var mangaDoc = web.Load(link.Attributes["href"].Value);

                        var nameDiv = mangaDoc.DocumentNode.SelectSingleNode("//div[@class='media-name__main']");
                        _newManga.Name = nameDiv.InnerText;

                        var altNameDiv = mangaDoc.DocumentNode.SelectSingleNode("//div[@class='media-name__alt']");
                        _newManga.SecondName = altNameDiv.InnerText;

                        var ratingDiv = mangaDoc.DocumentNode.SelectSingleNode("//div[@class='media-rating__value']");
                        _newManga.Mark = float.Parse(ratingDiv.InnerText);

                        var infoItems = mangaDoc.DocumentNode.SelectNodes("//div[@class='media-info-list__item'] | //a[@class='media-info-list__item']");
                        if (infoItems != null)
                        {
                            foreach (var item in infoItems)
                            {
                                if (item.SelectSingleNode(".//div[@class='media-info-list__title']").InnerText == "Тип")
                                {
                                    var mangaTypeDiv = item.SelectSingleNode(".//div[@class='media-info-list__value']");
                                    _newManga.MangaType = mangaTypeDiv.InnerText;
                                }

                                if (item.SelectSingleNode(".//div[@class='media-info-list__title']").InnerText == "Год релиза")
                                {
                                    var yearDiv = item.SelectSingleNode(".//div[@class='media-info-list__value']");
                                    _newManga.Year = int.Parse(yearDiv.InnerText);
                                }

                                if (item.SelectSingleNode(".//div[@class='media-info-list__title']").InnerText == "Статус тайтла")
                                {
                                    var exitStatusDiv = item.SelectSingleNode(".//div[@class='media-info-list__value']");
                                    _newManga.ExitStatus = exitStatusDiv.InnerText;
                                }

                                if (item.SelectSingleNode(".//div[@class='media-info-list__title']").InnerText == "Статус перевода")
                                {
                                    var translateStatusDiv = item.SelectSingleNode(".//div[contains(@class, 'media-info-list__value')]");
                                    _newManga.TranslateStatus = translateStatusDiv.InnerText;
                                }

                                if (item.SelectSingleNode(".//div[@class='media-info-list__title']").InnerText == "Загружено глав")
                                {
                                    var chapterCountDiv = item.SelectSingleNode(".//div[contains(@class, 'media-info-list__value')]");
                                    _newManga.ChapterCount = int.Parse(chapterCountDiv.InnerText);
                                }
                            }
                        }

                        _mangas.Add(_newManga);
                    }
                }

            }

            return _mangas;
        }
    }
}
