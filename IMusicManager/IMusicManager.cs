using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Music.MusicManager
{
    public interface IMusicManager
    {
        Task<MusicFile> UpsertMusicFile(MusicFile file);

        Task<MusicFile> GetMusicFile(Guid id);

        Task<bool> DeleteMusicFile(Guid id, bool deleteBlobs);

        Task<IEnumerable<MusicFile>> GetAllMusicFiles(String user);
    }
}
