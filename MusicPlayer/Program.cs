using SpotifyAPI.Web;

namespace MusicPlayer
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Opens MainForm at Start UP
            Application.Run(new MainForm());
        }
    }
}
