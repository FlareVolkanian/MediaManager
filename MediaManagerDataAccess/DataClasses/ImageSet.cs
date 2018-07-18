using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{
    public class ImageSet : Taggable
    {
        internal List<Guid> ImageIDS { get; set; }
        public string SetName { get; internal set; }

        public ImageSet(Guid ID) : base(ID) { }

        public ImageSet(Guid ID, string Name) : this(ID)
        {
            SetName = Name;
        }
    }
}
