using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using Image = System.Drawing.Image;

namespace MusicPlayer
{
    internal class TrackMetadata
    {
        private string track;
        private bool isLocal;
        public static string trackName {  get; set; }
        public static string albumName { get; set; }
        public static string artistName { get; set; }
        public static int totalMilliSeconds { get; set; }
        public static object trackPoster { get; set; }
        public static string trackPreviewURL { get; set; }
        public TrackMetadata()
        {
            
        }

        public TrackMetadata(string track, bool isLocal)
        {
            this.track = track;
            this.isLocal = isLocal;
        }

        public async Task SetOnlineTrackMetadata()
        {
            try
            {
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                var resultTrack = await spotify.Tracks.Get(track);
                if (resultTrack == null)
                {
                    Console.WriteLine("Error getting track!"); return;
                }
                else
                {
                    trackName = resultTrack.Name;
                    artistName = resultTrack.Artists[0].Name;
                    trackPoster = resultTrack.Album.Images[0].Url;
                    totalMilliSeconds = resultTrack.DurationMs;
                    trackPreviewURL = resultTrack.PreviewUrl;
                }

                var result = await spotify.Playlists.GetItems("37i9dQZF1EQnqst5TRi17F", new PlaylistGetItemsRequest()
                {
                    Market = "BD", // Example: set the market
                });

                await foreach (var item in spotify.Paginate(result))
                {
                    Console.WriteLine(item.Track);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SetLocalTrackMetadata()
        {
            var file = TagLib.File.Create(track);

            trackName = file.Tag.Title != null ? file.Tag.Title : "Unknown";
            artistName = file.Tag.Artists != null && file.Tag.Artists.Length > 0 ? file.Tag.Artists[0] : "Unknown";
            totalMilliSeconds = (int)file.Properties.Duration.TotalMilliseconds;

            IPicture[] pictures = file.Tag.Pictures;

            // Check if there are pictures in the metadata
            if (pictures != null && pictures.Length > 0)
            {
                // Assuming you want the first picture (cover art)
                byte[] imageBytes = pictures[0].Data.Data;

                // Convert the image bytes to an Image or Bitmap
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    trackPoster = Image.FromStream(ms);
                }
            }
            else
            {
                trackPoster = Resource1.posterPlaceholder;
            }
        }

        public static async Task<SpotifyClientConfig> StartAuthentication()
        {
            var config = SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("600ba51cf6464b29b90edc07050e54d9", "9a6802e6a09248808dce71025df7ae97"));

            return config;
        }
    }
}
