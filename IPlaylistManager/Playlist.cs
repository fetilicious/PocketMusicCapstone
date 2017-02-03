using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Playlist.PlaylistManager
{
    public class Playlist
    {
        public Guid Id;

        public String Name;

        public Dictionary<Guid, User> ConnectedUsers;
    }
}
