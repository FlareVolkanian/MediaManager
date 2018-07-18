using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{
    public class ResultSet : List<Taggable>
    {
        public ResultSet(IEnumerable<Taggable> Media) : base(Media)
        {

        }

        public ResultSet()
        {
        }

        public List<TagOverview> Tags
        {
            get
            {
                Dictionary<string, TagOverview> results = new Dictionary<string, TagOverview>();
                foreach(Taggable tgbl in this)
                {
                    foreach(string tag in tgbl.TagList)
                    {
                        if(results.ContainsKey(tag))
                        {
                            results[tag].ItemsWithTag++;
                        }
                        else
                        {
                            TagOverview overview = new TagOverview() { Name = tag, ItemsWithTag = 1 };
                            results.Add(tag, overview);
                        }
                    }
                }
                return results.Select(kvp => kvp.Value).ToList();
            }
        }
    }
}
