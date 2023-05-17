using MyMangaReader.Services.Interfaces;
using MyMangaReader.Services.SaveLoadSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMangaReader.Services.Factories.SaveLoadFactory
{
    public class AndroidLoadSettingsFactory : BaseLoadFactory
    {
        public override ILoadSettings LoadSettings()
        {
            return new AndroidLoadSettings();
        }
    }
}
