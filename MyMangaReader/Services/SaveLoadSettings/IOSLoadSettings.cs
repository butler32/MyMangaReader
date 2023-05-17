using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.Services.SaveLoadSettings
{
    public class IOSLoadSettings : ILoadSettings
    {
        string folderName = "Pudge Manga Club";
        string data;
        string fileName = "config.txt";
        string folderPath;

        public string LoadSettings()
        {
            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);
            }

            string filePath = Path.Combine(folderPath, fileName);
            Directory.CreateDirectory(folderPath);

            if (!File.Exists(filePath))
            {
                data = "lr^";

                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.Write(data);
                }
            }
            else
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    data = reader.ReadToEnd();
                }
            }

            return data;
        }
    }
}
