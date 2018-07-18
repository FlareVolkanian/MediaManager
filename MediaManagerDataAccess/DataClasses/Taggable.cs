using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{ 
    public abstract class Taggable
    {
        public Guid ID { get; internal set; }
        public HashSet<string> Tags { get; internal set; }
        public List<string> TagList
        {
            get
            {
                return Tags.ToList();
            }
        }

        public Taggable(Guid ID)
        {
            this.ID = ID;
        }
    }
}
