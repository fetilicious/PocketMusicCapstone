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
        bool UpsertFileItem(FileItem fileItem);

        bool DeleteFileItem(Guid id);

        bool GetFileItem(Guid id);
    }
}
