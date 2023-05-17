namespace MyMangaReader.Models
{
    public class MangaModel : BaseModel
    {
        private long _id;
        private string _name;
        private string _secondName;
        private Image _image;
        private string _description;
        private int _chapterCount;
        private string _exitStatus;
        private string _translateStatus;
        private ICollection<String> _genres;
        private float _mark;
        private string _mangaType;
        private string _link;
        private int _year;


        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged();
            }
        }

        public string Link
        {
            get { return _link; }
            set
            {
                _link = value;
                OnPropertyChanged();
            }
        }

        public long Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public Image Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }

        public int ChapterCount
        {
            get { return _chapterCount; }
            set
            {
                _chapterCount = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public ICollection<String> Genres
        {
            get { return _genres; }
            set
            {
                _genres = value;
                OnPropertyChanged();
            }
        }

        public string ExitStatus
        {
            get { return _exitStatus; }
            set
            {
                _exitStatus = value;
                OnPropertyChanged();
            }
        }
        public string TranslateStatus
        {
            get { return _translateStatus; }
            set
            {
                _translateStatus = value;
                OnPropertyChanged();
            }
        }

        public float Mark
        {
            get { return _mark; }
            set
            {
                _mark = value;
                OnPropertyChanged();
            }
        }

        public string SecondName
        {
            get { return _secondName; }
            set
            {
                _secondName = value;
                OnPropertyChanged();
            }
        }

        public string MangaType
        {
            get { return _mangaType; }
            set
            {
                _mangaType = value;
                OnPropertyChanged();
            }
        }
    }
}
