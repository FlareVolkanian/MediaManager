using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{
    public class MediaItem : Taggable
    {
        public string Path { get; internal set; }
        public string Creator { get; internal set; }

        public MediaItem(string Path, Guid ID) : base(ID)
        {
            this.Path = Path;
            this.ID = ID;
        }

        public MediaItem(string Path) : this()
        {
            this.Path = Path;
        }

        public MediaItem() : base(Guid.NewGuid())
        {
            
        }
    }
}
