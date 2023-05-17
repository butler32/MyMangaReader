using MyMangaReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMangaReader.Services.Interfaces
{
    public interface ISearchManga
    {
        public ICollection<MangaModel> SearchManga(string name);
    }
}
