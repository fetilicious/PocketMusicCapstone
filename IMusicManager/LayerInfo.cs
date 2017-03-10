using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMusic.Music.MusicManager
{
    public class LayerInfo
    {
        public string Name;

        public string Url;

        public string Description;

        public bool ReadyToUse;

        public LayerInfo(string name, string description, bool readyToUse)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(name);
            }

            Name = name;
            Description = description;
            ReadyToUse = readyToUse;
        }

    }
}
