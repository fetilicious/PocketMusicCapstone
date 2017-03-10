using PocketMusic.Music.MusicManager;
using PocketMusic.Storage.DataStorage.Models;
using PocketMusic.Storage.DocumentDBStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Playlist.PlaylistManager
{
    public class PlaylistManager : IPlaylistManager
    {

        DocumentDBStorage<PlaylistFile> _storage;

        public PlaylistManager()
        {
            _storage = new DocumentDBStorage<PlaylistFile>(Storage.DataStorage.PMDataType.Playlist);
        }

        public async Task<PlaylistFile> CreatePlaylist(String name, MusicFile music, User user)
        {
            #region Validation

            if (music == null)
            {
                throw new ArgumentNullException(nameof(music));
            }
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            if (!music.Layers.Any())
            {
                throw new ArgumentException(nameof(music.Layers));
            }

            #endregion 

            PlaylistFile playlist = new PlaylistFile(Guid.NewGuid(), name);

            playlist.ConnectedUsers.Add(user.UserName, user);
            
            foreach (var layer in music.Layers)
            {
                Tuple<User,LayerInfo> availableLayer = new Tuple<User, LayerInfo>(null, layer.Value);
                playlist.AvailableLayers.Add(availableLayer);
            }

            if (!await _storage.UpsertFileItem(playlist))
            {
                return null;
            }

            return playlist;
        }

        public async Task<bool> DeletePlaylist(Guid playlistId)
        {
            return await _storage.DeleteFileItem(playlistId);
        }

        public async Task<bool> DisconnectFromPlaylist(Guid playlistId, User user)
        {
            #region Validation

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            #endregion

            var playlist = await _storage.GetFileItem(playlistId);

            playlist.ConnectedUsers.Remove(user.UserName);
            foreach (var layer in playlist.AvailableLayers)
            {
                if (layer.Item1 != null && String.Compare(layer.Item1.UserName,user.UserName) == 0)
                {
                    playlist.AvailableLayers.Remove(layer);
                }
            }

            if (!await _storage.UpsertFileItem(playlist))
            {
                return false;
            }

            return true;
        }

        public async Task<PlaylistFile> ConnectToPlaylistLayer(Guid playlistId, string layerName, User user)
        {
            #region Validation

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            if (String.IsNullOrWhiteSpace(layerName))
            {
                throw new ArgumentNullException(nameof(layerName));
            }

            #endregion

            var playlist = await _storage.GetFileItem(playlistId);

            playlist.ConnectedUsers.Remove(user.UserName);
            foreach (var layer in playlist.AvailableLayers)
            {
                if (layer.Item1 == null && String.Compare(layer.Item2.Name, layerName) == 0)
                {
                    playlist.AvailableLayers.Remove(layer);
                    playlist.AvailableLayers.Add(new Tuple<User, LayerInfo>(user, layer.Item2));
                }
            }

            if (!await _storage.UpsertFileItem(playlist))
            {
                return null;
            }

            return playlist;
        }

        public async Task<IEnumerable<PlaylistFile>> GetAllPlaylists()
        {
            return await _storage.QueryFileItems("SELECT * FROM p");
        }

        public async Task<PlaylistFile> GetPlaylist(Guid playlistId)
        {
            return await _storage.GetFileItem(playlistId);
        }
    }
}
