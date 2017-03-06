using AzureBlobStorage;
using PocketMusic.Storage.DataStorage;
using PocketMusic.Storage.DocumentDBStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Music.MusicManager
{
    public class MusicManager : IMusicManager
    {
        private DocumentDBStorage<MusicFile> _documentDBStorage;

        private BlobStorage _blobStorage;

        public const string ContainerName = "main";

        public MusicManager()
        {
            _documentDBStorage = new DocumentDBStorage<MusicFile>(PMDataType.Music);
            _documentDBStorage.CreateDatabaseAndDocument();
            _blobStorage = new BlobStorage(ContainerName);
        }

        public async Task<bool> DeleteMusicFile(Guid id)
        {
            return await _documentDBStorage.DeleteFileItem(id);
        }

        public async Task<MusicFile> GetMusicFile(Guid id)
        {
            return await _documentDBStorage.GetFileItem(id);
        }

        public async Task<IEnumerable<MusicFile>> GetAllMusicFiles(string user)
        {
            if (String.IsNullOrEmpty(user))
            {
                return await _documentDBStorage.QueryFileItems("SELECT * FROM m");
            }
            else
            {
                string query = String.Format("SELECT * FROM Music m WHERE m.UserName = '{0}'", user);
                return await _documentDBStorage.QueryFileItems(query);
            }
        }

        public async Task<MusicFile> UpsertMusicFile(MusicFile file)
        {
            #region Validation

            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }
            if (String.IsNullOrEmpty(file.Name))
            {
                throw new ArgumentNullException(nameof(file.Name));
            }
            if (String.IsNullOrEmpty(file.UserName))
            {
                throw new ArgumentNullException(nameof(file.UserName));
            }

            #endregion

            if (file.id == null)
            {
                file.id = Guid.NewGuid();
            }
            if (file.CreationDate == null)
            {
                file.CreationDate = DateTime.Now;
            }

            // Upload blobs using blob storage
            if (file.Layers.Any())
            {
                foreach (var layer in file.Layers)
                {
                    // fire and forget upload
                    Guid id = file.id ?? default(Guid);
                    _blobStorage.UploadBlob(id, layer.Value.Name, layer.Value.Url.ToString(), false);
                }
            }

            // Insert database record
            if (!await _documentDBStorage.UpsertFileItem(file))
            {
                return null;
            }

            return file;
        }


    }
}
