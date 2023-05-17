﻿using MyMangaReader.Services.Interfaces;
using MyMangaReader.Services.SaveLoadSettings;

namespace MyMangaReader.Services.Factories.SaveLoadFactory
{
    public class AndroidSaveSettingsFactory : BaseSaveFactory
    {
        public override ISaveSettings SaveSettings()
        {
            return new AndroidSaveSettings();
        }
    }
}
