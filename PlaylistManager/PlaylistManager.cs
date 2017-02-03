using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Playlist.PlaylistManager
{
    public class PlaylistManager : IPlaylistManager
    {
        public bool ConnectToPlaylist(Guid playlistId, User user)
        {
            throw new NotImplementedException();
        }

        public bool CreatePlaylist(Guid playlistId, MusicFile music, User user)
        {
            throw new NotImplementedException();
        }

        public bool DeletePlaylist(Guid playlistId)
        {
            throw new NotImplementedException();
        }

        public bool DisconnectFromPlaylist(Guid playlistId, User user)
        {
            throw new NotImplementedException();
        }
    }
}
