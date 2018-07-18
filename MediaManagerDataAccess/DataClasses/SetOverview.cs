using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{
    public class SetOverview
    {
        public Guid ID { get; internal set; }
        public string Name { get; internal set; }
        public int NumberOfImages { get; internal set; }
    }
}
