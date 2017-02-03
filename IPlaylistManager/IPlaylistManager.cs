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
        bool CreatePlaylist(Guid playlistId, MusicFile music, User user);

        bool DeletePlaylist(Guid playlistId);

        bool ConnectToPlaylist(Guid playlistId, User user);

        bool DisconnectFromPlaylist(Guid playlistId, User user);
    }
}
