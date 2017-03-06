using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Storage.BlobStorage
{
    public interface IBlobStorage
    {
        /// <summary>
        /// Uploads a Blob 
        /// </summary>
        /// <param name="fileId">fileID assosciated with the blob</param>
        /// <param name="blobName">name of the blob</param>
        /// <param name="localPath">local path blob is stored</param>
        /// <param name="deleteLocal">local file is deleted if true</param>
        /// <returns></returns>
        Task<Uri> UploadBlob(Guid fileId, string blobName, string localPath, bool deleteLocal);

        /// <summary>
        /// Deletes a blob
        /// </summary>
        /// <param name="fileId">fileID assosciated with the blob</param>
        /// <param name="blobName">name of the blob</param>
        /// <returns></returns>
        Task<bool> DeleteBlob(Guid fileId, string blobName);
    }
}
