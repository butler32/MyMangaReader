using MyMangaReader.Models;
using MyMangaReader.Services.GetMangaFactory;
using MyMangaReader.Services.Interfaces;
using System.Windows.Input;

namespace MyMangaReader.ViewModels
{
    public class SubscribedMangaViewModel : BaseViewModel
    {
        private ICollection<MangaModel> _mangas;

        public ICollection<MangaModel> Mangas
        {
            get { return _mangas; }
            set
            {
                _mangas = value;
                OnPropertyChanged();
            }
        }

        private BaseGetSubscribedMangaFactory _getSubscribedMangaFactory;
        private IGetSubscribedManga _getSubscribedMangaInstance;

        public SubscribedMangaViewModel()
        {
            GetManga = new Command(GetMangaExecute);
        }

        public ICommand GetManga;

        private void GetMangaExecute()
        {
            if (SettingsViewModel.SubscribedMangas != null)
            {
                foreach (var id in SettingsViewModel.SubscribedMangas)
                {
                    _getSubscribedMangaFactory = new GetMangaLibSubscribedMangaFactory();
                    _getSubscribedMangaInstance = _getSubscribedMangaFactory.CreateInstance();

                    Mangas.Add(_getSubscribedMangaInstance.GetSubscribedManga(id));
                }
            }
            else
            {
                Mangas = null;
            }
        }
    }
}
