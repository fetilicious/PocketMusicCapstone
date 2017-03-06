using PocketMusic.Storage.DataStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Storage.DataStorage
{
    public interface IStorage<T>
    {
        Task<bool> UpsertFileItem(T fileItem);

        Task<bool> DeleteFileItem(Guid id);

        Task<T> GetFileItem(Guid id);

        Task<IEnumerable<T>> QueryFileItems(string query);
    }
}
