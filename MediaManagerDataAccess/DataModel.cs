using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{
    internal class DataModel
    {
        public Dictionary<Guid, Taggable> Taggables;

        public DataModel()
        {
            Taggables = new Dictionary<Guid, Taggable>();
        }
    }
}
