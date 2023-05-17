namespace MyMangaReader.Models
{
    public class ChapterModel : BaseModel
    {
        private int _tome;
        private int _chapter;
        private string _date;
        private string _chapterName;
        private bool _chapterRead;

        public int Tome
        {
            get { return _tome; }
            set
            {
                _tome = value;
                OnPropertyChanged();
            }
        }

        public int Chapter
        {
            get { return _chapter; }
            set
            {
                _chapter = value;
                OnPropertyChanged();
            }
        }

        public string Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public bool ChapterRead
        {
            get { return _chapterRead; }
            set
            {
                _chapterRead = value;
                OnPropertyChanged();
            }
        }

        public string ChapterName
        {
            get { return _chapterName; }
            set
            {
                _chapterName = value;
                OnPropertyChanged();
            }
        }
    }
}
