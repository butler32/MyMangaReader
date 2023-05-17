using MyMangaReader.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMangaReader.Services.Factories.SaveLoadFactory
{
    public abstract class BaseLoadFactory
    {
        public abstract ILoadSettings LoadSettings();
    }
}
