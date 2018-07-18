using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDataModel
{
    public class DataAccess
    {

        private DataModel Model;

        public DataAccess()
        {
            Model = new DataModel();
        }

        public void SaveModel(string FilePath)
        {
            string contents = Newtonsoft.Json.JsonConvert.SerializeObject(Model);
            File.WriteAllText(FilePath, contents);
        }

        public void LoadModelFromFile(string FilePath)
        {
            string content = File.ReadAllText(FilePath);
            Model = Newtonsoft.Json.JsonConvert.DeserializeObject<DataModel>(content);
        }

        public MediaSet AddMediaSet(string SetName)
        {
            ResultSet sets = GetAllMediaSets();
            if (!sets.Exists(s => (s as MediaSet).SetName == SetName))
            {
                Guid setID = GetGuid();
                MediaSet set = new MediaSet(setID, SetName);
                Model.Taggables.Add(setID, set);
                return set;
            }
            return null;
        }

        public bool AddMediaItemToSet(string SetName, Guid ImageID)
        {
            ResultSet sets = GetAllMediaSets();
            if(sets.Exists(s => (s as MediaSet).SetName == SetName))
            {
                MediaSet set = sets.Find(s => (s as MediaSet).SetName == SetName) as MediaSet;
                set.ImageIDS.Add(ImageID);
                return true;
            }
            return false;
        }

        public MediaItem AddMediaItem(string Path)
        {
            Guid imageID = GetGuid();
            MediaItem image = new MediaItem(Path, imageID);
            Model.Taggables.Add(imageID, image);
            return image;
        }

        public void AddTagToItem(Guid ImageID, string Tag)
        {
            if(Model.Taggables.ContainsKey(ImageID))
            {
                Taggable tgbl = Model.Taggables[ImageID];
                if(!tgbl.Tags.Contains(Tag))
                {
                    tgbl.Tags.Add(Tag);
                }
            }
        }

        public ResultSet GetAllItems()
        {
            return new ResultSet(Model.Taggables.Select(kvp => kvp.Value));
        }

        public ResultSet GetAllMediaItems()
        {
            return new ResultSet(Model.Taggables.Select(kvp => kvp.Value).ToList().FindAll(t => t is MediaItem));
        }

        public ResultSet GetAllMediaSets()
        {
            return new ResultSet(Model.Taggables.Select(kvp => kvp.Value).ToList().FindAll(t => t is MediaSet));
        }

        /*public ResultSet RunQuery(string Query)
        {

        }*/

        public ResultSet GetMediaItemsForSet(Guid SetID)
        {
            if(Model.Taggables.ContainsKey(SetID))
            {
                MediaSet set = Model.Taggables[SetID] as MediaSet;
                if(set != null)
                {
                    ResultSet results = new ResultSet();
                    foreach(Guid imageID in set.ImageIDS)
                    {
                        results.Add(Model.Taggables[imageID]);
                    }
                    return results;
                }
            }
            return new ResultSet();
        }

        private Guid GetGuid()
        {
            Guid id = Guid.NewGuid();
            while (Model.Taggables.ContainsKey(id))
            {
                id = Guid.NewGuid();
            }
            return id;
        }
    }
}
