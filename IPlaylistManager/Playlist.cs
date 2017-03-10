﻿using PocketMusic.Music.MusicManager;
using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Playlist.PlaylistManager
{
    public class PlaylistFile
    {
        public Guid id { get; set; }

        public String Name { get; set; }

        public Dictionary<String, User> ConnectedUsers { get; set; }

        public List<Tuple<User, LayerInfo>> AvailableLayers { get; set; }

        public PlaylistFile(Guid ident, String name)
        {
            id = ident;
            Name = name;
            ConnectedUsers = new Dictionary<string, User>();
            AvailableLayers = new List<Tuple<User, LayerInfo>>();
        }

    }
}
