using MyMangaReader.Services.Interfaces;

namespace MyMangaReader.Services.SaveLoadSettings
{
    public class WindowsSaveSettings : ISaveSettings
    {
        string folderName = "Pudge Manga Club";
        string fileName = "config.txt";
        string folderPath;

        public void SaveSettings(string data)
        {

            folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName);


            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, fileName);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(data);
            }
        }
    }
}
