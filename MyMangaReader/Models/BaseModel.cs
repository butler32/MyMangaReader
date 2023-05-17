using MyMangaReader.Enums;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyMangaReader.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        private string _site = SiteEnum.mangalib.ToString();

        public string Site
        {
            get { return _site; }
            set { _site = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
