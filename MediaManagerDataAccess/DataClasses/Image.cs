using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{
    public class Image : Taggable
    {
        public string Path { get; internal set; }
        public bool IsEncrpyted { get; internal set; }
        public byte[] IV { get; internal set; }

        public Image(string Path, Guid ID) : base(ID)
        {
            this.Path = Path;
            this.ID = ID;
        }

        public Image(string Path) : this()
        {
            this.Path = Path;
        }

        public Image() : base(Guid.NewGuid())
        {
            
        }
    }
}
