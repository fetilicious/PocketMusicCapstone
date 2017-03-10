using PocketMusic.Music.MusicManager;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Storage.StaticStorage
{
    public static class TemporaryStorage
    {
        static TemporaryStorage()
        {
            _temporaryStorage.TryAdd(Guid.NewGuid(), new MusicFile { id = Guid.NewGuid(), Name = "Don't Stop Believing", });
            _temporaryStorage.TryAdd(Guid.NewGuid(), new MusicFile { id = Guid.NewGuid(), Name = "Paralyzer", });
            _temporaryStorage.TryAdd(Guid.NewGuid(), new MusicFile { id = Guid.NewGuid(), Name = "Viva La Vida", });
        }

        private static ConcurrentDictionary<Guid, MusicFile> _temporaryStorage = new ConcurrentDictionary<Guid, MusicFile>();

        //public async static Task<bool> UpsertMusicFile(MusicFile file)
        //{
        //    #region Validation

        //    if (file == null)
        //    {
        //        return false;
        //    }
        //    if (_temporaryStorage.ContainsKey(file.id))
        //    {
        //        MusicFile outFile;
        //        // Temporary for UPSERT
        //        _temporaryStorage.TryRemove(file.id, out outFile);
        //    }

        //    #endregion

        //    _temporaryStorage.TryAdd(file.id, file);

        //    return true;
        //}

        //public async static Task<bool> DeleteMusicFile(int id)
        //{
        //    #region Validation

        //    if (!_temporaryStorage.ContainsKey(id))
        //    {
        //        return false;
        //    }

        //    #endregion

        //    MusicFile outFile;

        //    _temporaryStorage.TryRemove(id, out outFile);

        //    return true;
        //}

        //public async static Task<IEnumerable<MusicFile>> GetAllMusicFiles()
        //{
        //    List<MusicFile> files = new List<MusicFile>();

        //    foreach (var kvp in _temporaryStorage)
        //    {
        //        files.Add(kvp.Value);
        //    }

        //    return files;
        //}

        //public async static Task<MusicFile> GetMusicFile(int id)
        //{
        //    MusicFile file = null;

        //    if (!_temporaryStorage.TryGetValue(id, out file))
        //    {
        //        return null;
        //    }

        //    return file;
        //}

    }
}
