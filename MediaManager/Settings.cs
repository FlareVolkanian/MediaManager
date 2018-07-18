using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTagII
{
    class Settings
    {
        public Settings()
        {
            ImageLocations = new List<string>();
        }

        public List<string> ImageLocations { get; set; }
    }
}
