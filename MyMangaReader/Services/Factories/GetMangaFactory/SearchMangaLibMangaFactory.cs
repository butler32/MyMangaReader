using MyMangaReader.Services.GetManga;
using MyMangaReader.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMangaReader.Services.Factories.GetMangaFactory
{
    public class SearchMangaLibMangaFactory : BaseSearchMangaFactory
    {
        public override ISearchManga CreateInstance()
        {
            return new SearchMangaLibManga();
        }
    }
}
