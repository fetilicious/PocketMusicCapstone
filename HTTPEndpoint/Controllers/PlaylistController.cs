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
    public class PlaylistController
    {
        private IPlaylistManager _playlistManager;

        public PlaylistController(IPlaylistManager playlistManager)
        {
            if (playlistManager == null)
            {
                throw new ArgumentNullException(nameof(playlistManager));
            }
            _playlistManager = playlistManager;
        }

        [Route("api/playlist/")]
        [HttpGet]
        public async Task<IEnumerable<PlaylistFile>> GetAllPlaylists()
        {
            return await _playlistManager.GetAllPlaylists();
        }

        [Route("api/playlist/{username}/{name}")]
        [HttpPost]
        public async Task<PlaylistFile> CreatePlaylist(string username, string name, MusicFile file)
        {
            User user = new User(username);

            return await _playlistManager.CreatePlaylist(name, file, user);
        }


    }
}
