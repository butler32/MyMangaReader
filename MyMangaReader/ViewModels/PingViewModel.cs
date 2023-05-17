using System.Net.NetworkInformation;

namespace MyMangaReader.ViewModels
{
    public class PingViewModel : BaseViewModel
    {
        public static async Task<string> PingMultipleSites()
        {
            Uri mangalibUri = new Uri("https://mangalib.me");
            Uri readmangaUri = new Uri("https://readmanga.live");
            Uri newmangaUri = new Uri("https://newmanga.org/");

            long minPing = long.MaxValue;
            string minSite = string.Empty;

            List<string> sites = new List<string> { mangalibUri.Host, readmangaUri.Host, newmangaUri.Host };

            Ping ping = new Ping();

            foreach (var site in sites)
            {
                try
                {
                    PingReply reply = await ping.SendPingAsync(site);
                    if (reply.Status == IPStatus.Success)
                    {
                        if (minPing > reply.RoundtripTime)
                        {
                            minPing = reply.RoundtripTime;
                            minSite = site;
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }

            return minSite;
        }
    }
}
