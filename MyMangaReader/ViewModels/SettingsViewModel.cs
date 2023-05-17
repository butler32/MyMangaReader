namespace MyMangaReader.ViewModels
{
    public static class SettingsViewModel
    {
        private static GetSettingsViewModel getSettings = new GetSettingsViewModel();
        private static string readMethod;
        public static string ReadMethod
        {
            get
            {
                return readMethod;
            }
            set
            {
                readMethod = value;
            }
        }

        private static int[] subscribedMangas;
        public static int[] SubscribedMangas
        {
            get
            {
                return subscribedMangas;
            }
            set
            {
                subscribedMangas = value;
            }
        }

        public static void Reset()
        {
            Load();
        }

        public static void Load()
        {
            Parse(getSettings.GetSettings());
        }

        private static void Parse(string data)
        {
            var splitSettings = data.Split('^');
            ReadMethod = splitSettings[0];
            if (splitSettings.Length > 1)
            {
                var splitSubscribedMangas = splitSettings[1].Split('/');
                for (int i = 0; i < splitSubscribedMangas.Length; i++)
                {
                    subscribedMangas[i] = Convert.ToInt32(splitSubscribedMangas[i]);
                }
            }
        }
    }
}