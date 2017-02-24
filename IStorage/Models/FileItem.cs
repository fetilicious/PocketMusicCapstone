using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Storage.DataStorage.Models
{
    public class FileItem
    {
        public FileItem(Guid ident, PMDataType type)
        {
            id = ident;
            Type = type;
            Data = new Dictionary<string, string>();
            MetaData = new Dictionary<string, string>();
            BlobLinks = new Dictionary<string, string>();
        }

        public Guid id { get; }

        public PMDataType Type { get; }

        public Dictionary<String,String> Data { get; }

        public Dictionary<String,String> MetaData { get; }

        public Dictionary<String,String> BlobLinks { get; }
    }
}
