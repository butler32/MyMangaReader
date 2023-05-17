using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.Services.SaveLoadSettings
{
    public class AndroidSaveSettings : ISaveSettings
    {
        string folderName = "Pudge Manga Club";
        string fileName = "config.txt";
        string folderPath;

        public void SaveSettings(string data)
        {
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                //folderPath = Path.Combine(Android.App.Application.Context.GetExternalFilesDir(null).AbsolutePath, folderName);
            }

            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(data);
            }
        }
    }
}
