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
        Task<Playlist> CreatePlaylist(String name, MusicFile music, User user);

        Task<bool> DeletePlaylist(Guid playlistId);

        Task<IEnumerable<Playlist>> GetAllPlaylists();

        Task<Playlist> GetPlaylist(Guid playlistId);

        Task<Playlist> ConnectToPlaylistLayer(Guid playlistId, string layerName, User user);

        Task<bool> DisconnectFromPlaylist(Guid playlistId, User user);
    }
}
