using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Storage.DataStorage.Models
{
    public class FileItem
    {
        public Guid Id { get; set; }

        public PMDataType Type { get; set; }

        public Dictionary<String,String> Data { get; set; }

        public Dictionary<String, String> MetaData { get; set; }

        public Dictionary<String, String> BlobLinks { get; set; }
    }
}
