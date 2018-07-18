using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{
    public class MediaSet : Taggable
    {
        internal List<Guid> ImageIDS { get; set; }
        public string SetName { get; internal set; }

        public MediaSet(Guid ID) : base(ID) { }

        public MediaSet(Guid ID, string Name) : this(ID)
        {
            SetName = Name;
        }
    }
}
