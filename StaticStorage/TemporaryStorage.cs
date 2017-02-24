using PocketMusic.Storage.DataStorage.Models;
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
            _temporaryStorage.TryAdd(1, new MusicFile { Id = 1, Name = "Don't Stop Believing", });
            _temporaryStorage.TryAdd(2, new MusicFile { Id = 2, Name = "Paralyzer", });
            _temporaryStorage.TryAdd(3, new MusicFile { Id = 3, Name = "Viva La Vida", });
        }

        private static ConcurrentDictionary<int, MusicFile> _temporaryStorage = new ConcurrentDictionary<int, MusicFile>();

        public async static Task<bool> UpsertMusicFile(MusicFile file)
        {
            #region Validation

            if (file == null)
            {
                return false;
            }
            if (_temporaryStorage.ContainsKey(file.Id))
            {
                MusicFile outFile;
                // Temporary for UPSERT
                _temporaryStorage.TryRemove(file.Id, out outFile);
            }

            #endregion

            _temporaryStorage.TryAdd(file.Id, file);

            return true;
        }

        public async static Task<bool> DeleteMusicFile(int id)
        {
            #region Validation

            if (!_temporaryStorage.ContainsKey(id))
            {
                return false;
            }

            #endregion

            MusicFile outFile;

            _temporaryStorage.TryRemove(id, out outFile);

            return true;
        }

        public async static Task<IEnumerable<MusicFile>> GetAllMusicFiles()
        {
            List<MusicFile> files = new List<MusicFile>();

            foreach (var kvp in _temporaryStorage)
            {
                files.Add(kvp.Value);
            }

            return files;
        }

        public async static Task<MusicFile> GetMusicFile(int id)
        {
            MusicFile file = null;

            if (!_temporaryStorage.TryGetValue(id, out file))
            {
                return null;
            }

            return file;
        }

    }
}
