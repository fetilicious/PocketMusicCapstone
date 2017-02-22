using PocketMusic.Storage.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketMusic.Storage.DataStorage.Models;

namespace PocketMusic.Storage.DocumentDBStorage
{
    public class DocumentDBStorage : IStorage
    {
        public DocumentDBStorage()
        {

        }

        public bool DeleteFileItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool GetFileItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpsertFileItem(FileItem fileItem)
        {
            throw new NotImplementedException();
        }
    }
}
