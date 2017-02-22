using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Storage.DataStorage.Models
{
    public class MusicFile
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public Dictionary<String,String> BlobUrls { get; set; }

        public String Artist { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
