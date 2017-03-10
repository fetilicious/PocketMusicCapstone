using PocketMusic.Music.MusicManager;
using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Playlist.PlaylistManager
{
    public interface IPlaylistManager
    {
        Task<PlaylistFile> CreatePlaylist(String name, MusicFile music, User user);

        Task<bool> DeletePlaylist(Guid playlistId);

        Task<IEnumerable<PlaylistFile>> GetAllPlaylists();

        Task<PlaylistFile> GetPlaylist(Guid playlistId);

        Task<PlaylistFile> ConnectToPlaylistLayer(Guid playlistId, string layerName, User user);

        Task<bool> DisconnectFromPlaylist(Guid playlistId, User user);
    }
}
