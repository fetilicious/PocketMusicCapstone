using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Music.MusicManager
{
    public class MusicFile
    {
        public Guid? id { get; set; }

        public String Name { get; set; }

        public Dictionary<String, LayerInfo> Layers { get; set; }

        public String Artist { get; set; }

        public String UserName { get; set; }

        public DateTime? CreationDate { get; set; }

    }
}
