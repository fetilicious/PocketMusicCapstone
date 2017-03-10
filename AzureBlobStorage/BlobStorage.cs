using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using PocketMusic.Storage.BlobStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobStorage
{
    public class BlobStorage : IBlobStorage
    {
        private CloudStorageAccount _storageAccount;

        private CloudBlobContainer _blobContainer;

        private CloudBlobClient _blobClient;

        private const String _connectionString = "DefaultEndpointsProtocol=https;AccountName=pocketmusic;AccountKey=aCvYvX19UJN1pE90hmc3LE27fbf0tXDyKCxr9WenRk8xFPyEekx4YlKo3M/wlSMhfGFfoneIVF1YEiIYYHkiog==";

        public BlobStorage(String containerName)
        {
            _storageAccount = CloudStorageAccount.Parse(_connectionString);

            _blobClient = _storageAccount.CreateCloudBlobClient();

            _blobContainer = _blobClient.GetContainerReference(containerName);

            _blobContainer.CreateIfNotExists();

            _blobContainer.SetPermissions( new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
        }

        public async Task<Uri> UploadBlob(Guid fileId, string blobName, string localPath, bool deleteLocal)
        {
            if (String.IsNullOrWhiteSpace(blobName))
            {
                throw new ArgumentNullException(blobName);
            }
            if (String.IsNullOrWhiteSpace(localPath))
            {
                throw new ArgumentNullException(localPath);
            }
            
            try
            {
                String blobPath = String.Format("{0}/{1}", fileId.ToString("N"), blobName).Replace(" ", "").Replace("\"","");
                // Retrieve reference to a blob named "myblob".
                CloudBlockBlob blockBlob = _blobContainer.GetBlockBlobReference(blobPath);

                // Create or overwrite the "myblob" blob with contents from a local file.
                using (var fileStream = System.IO.File.OpenRead(localPath))
                {
                    await blockBlob.UploadFromStreamAsync(fileStream);
                }

                if (deleteLocal)
                {
                    File.Delete(localPath);
                }

                return blockBlob.Uri;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> DeleteBlob(Guid fileId, string blobName)
        {
            if (String.IsNullOrWhiteSpace(blobName))
            {
                throw new ArgumentNullException(blobName);
            }

            try
            {
                String blobPath = String.Format("{0}/{1}", fileId.ToString("N"), blobName);
                // Retrieve reference to a blob named "myblob".
                CloudBlockBlob blockBlob = _blobContainer.GetBlockBlobReference(blobPath);

                await blockBlob.DeleteAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
