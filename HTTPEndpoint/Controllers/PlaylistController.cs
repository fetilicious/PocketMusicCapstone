using PocketMusic.Music.MusicManager;
using PocketMusic.Playlist.PlaylistManager;
using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PocketMusic.Endpoint.HTTPEndpoint.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PlaylistController : ApiController
    {
        private IPlaylistManager _playlistManager;
        private IMusicManager _musicManager;

        public PlaylistController(IPlaylistManager playlistManager, IMusicManager musicManager)
        {
            if (playlistManager == null)
            {
                throw new ArgumentNullException(nameof(playlistManager));
            }
            if (musicManager == null)
            {
                throw new ArgumentNullException(nameof(musicManager));
            }

            _playlistManager = playlistManager;
            _musicManager = musicManager;
        }

        [Route("api/playlist/")]
        [HttpGet]
        public async Task<IEnumerable<PlaylistFile>> GetAllPlaylists()
        {
            try
            {
                return await _playlistManager.GetAllPlaylists();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("api/playlist/{username}/{name}/{musicId}")]
        [HttpPost]
        public async Task<PlaylistFile> CreatePlaylist(string username, string name, Guid musicId)
        {
            try
            {
                User user = new User(username);

                var musicFile = await _musicManager.GetMusicFile(musicId);

                if (musicFile == null)
                {
                    return null;
                }

                return await _playlistManager.CreatePlaylist(name, musicFile, user);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("api/playlist/{id}")]
        [HttpDelete]
        public async Task<bool> DeletePlaylist(Guid id)
        {
            try
            {
                return await _playlistManager.DeletePlaylist(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [Route("api/playlist/connect/{username}/{playlistId}/{layerName}")]
        [HttpPost]
        public async Task<PlaylistFile> ConnectToPlaylist(string username, Guid playlistId, string layerName)
        {
            try
            {
                User user = new User(username);

                return await _playlistManager.ConnectToPlaylistLayer(playlistId, layerName, user);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [Route("api/playlist/disconnect/{username}/{playlistId}")]
        [HttpPost]
        public async Task<bool> DisconnectFromPlaylist(string username, Guid playlistId)
        {
            try
            {
                User user = new User(username);

                return await _playlistManager.DisconnectFromPlaylist(playlistId, user);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
