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

        public async Task<bool> DeleteMusicFile(Guid id, bool deleteBlobs)
        {
            if (deleteBlobs)
            {
                var file = await _documentDBStorage.GetFileItem(id);
                // fire forget delete
                DeleteMusicBlobs(file);
            }
            
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

            #endregion

            if (file.id == null)
            {
                file.id = Guid.NewGuid();
            }
            if (file.CreationDate == null)
            {
                file.CreationDate = DateTime.Now;
            }

            // fire and forget
            UploadMusicBlobs(file);

            // Insert database record
            if (!await _documentDBStorage.UpsertFileItem(file))
            {
                return null;
            }

            return file;
        }

        private async Task UploadMusicBlobs(MusicFile file)
        {
            Guid id = file.id ?? default(Guid);
            Dictionary<string, LayerInfo> updatedLayers = new Dictionary<string, LayerInfo>();

            // Upload blobs using blob storage
            if (file.Layers.Any())
            {
                
                foreach (var layer in file.Layers)
                {
                    var uri = await _blobStorage.UploadBlob(id, layer.Key, layer.Value.Url, true);

                    LayerInfo newLayer = new LayerInfo(layer.Value.Name, layer.Value.Description, true);
                    newLayer.Url = uri.ToString();

                    updatedLayers.Add(newLayer.Name, newLayer);
                }
            }

            // updates database file
            var databaseFile = await _documentDBStorage.GetFileItem(id);
            databaseFile.Layers = updatedLayers;

            if (!await _documentDBStorage.UpsertFileItem(databaseFile))
            {
                // TODO: Log
            }
        }

        private async Task DeleteMusicBlobs(MusicFile file)
        {
            Guid id = file.id ?? default(Guid);
            // Delete blobs using blob storage
            if (file.Layers.Any())
            {
                foreach (var layer in file.Layers)
                {
                    if (!await _blobStorage.DeleteBlob(id, layer.Key))
                    {
                        // TODO: log
                    }
                }
            }
        }
    }
}
