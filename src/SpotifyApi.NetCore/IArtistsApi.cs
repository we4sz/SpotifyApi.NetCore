using System.Threading.Tasks;

namespace SpotifyApi.NetCore
{
    /// <summary>
    /// Defines a wrapper for the Spotify Web Artists API.
    /// </summary>
    public interface IArtistsApi
    {
        Task<T> GetArtist<T>(string artistId);
        Task<Artist> GetArtist(string artistId);

        Task<T> GetRelatedArtists<T>(string artistId);
        Task<Artist[]> GetRelatedArtists(string artistId);

        Task<Artist[]> SearchArtists(string artist);
        Task<Artist[]> SearchArtists(string artist, int limit);
        Task<Artist[]> SearchArtists(string artist, (int limit, int offset) limitOffset);
        Task<T> SearchArtists<T>(string artist, (int limit, int offset) limitOffset);
    }
}
