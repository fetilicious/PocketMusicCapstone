using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Playlist.MusicManager
{
    public interface IMusicManager
    {
        bool UpsertMusicFile(MusicFile file);

        bool DeleteMusicFile(int id);

        IEnumerable<MusicFile> GetAllMusicFiles();
    }
}
