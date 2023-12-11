using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class TrackMetadata
    {
        private string trackId;
        public static string trackName {  get; set; }
        public static string albumName { get; set; }
        public static string artistName { get; set; }
        public static int trackDuration { get; set; }
        public static string trackPoster { get; set; }
        public static string trackPreviewURL { get; set; }
        public TrackMetadata()
        {
            
        }

        public TrackMetadata(string trackId)
        {
            this.trackId = trackId;
        }

        public async Task SetMetadata()
        {
            try
            {
                var config = await StartAuthentication();
                var spotify = new SpotifyClient(config);

                var track = await spotify.Tracks.Get(trackId);
                if (track == null)
                {
                    Console.WriteLine("Error getting track!"); return;
                }
                else
                {
                    trackName = track.Name;
                    artistName = track.Artists[0].Name;
                    trackPoster = track.Album.Images[0].Url;
                    trackDuration = track.DurationMs;
                    trackPreviewURL = track.PreviewUrl;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
