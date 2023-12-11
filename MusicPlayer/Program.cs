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
            Application.Run(new MediaPlayerControlForm("7j8HcxX4b8ZIeHYn2VmK1h"));
        }
    }
}
