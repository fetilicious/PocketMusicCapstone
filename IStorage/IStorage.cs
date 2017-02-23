using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Storage.DataStorage
{
    public interface IStorage
    {
        Task<bool> UpsertFileItem(FileItem fileItem);

        Task<bool> DeleteFileItem(Guid id);

        Task<bool> GetFileItem(Guid id);
    }
}
