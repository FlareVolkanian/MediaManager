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

        public ImageSet AddImageSet(string SetName)
        {
            ResultSet sets = GetAllImageSets();
            if (!sets.Exists(s => (s as ImageSet).SetName == SetName))
            {
                Guid setID = GetGuid();
                ImageSet set = new ImageSet(setID, SetName);
                Model.Taggables.Add(setID, set);
                return set;
            }
            return null;
        }

        public bool AddImageToSet(string SetName, Guid ImageID)
        {
            ResultSet sets = GetAllImageSets();
            if(sets.Exists(s => (s as ImageSet).SetName == SetName))
            {
                ImageSet set = sets.Find(s => (s as ImageSet).SetName == SetName) as ImageSet;
                set.ImageIDS.Add(ImageID);
                return true;
            }
            return false;
        }

        public Image AddImage(string Path)
        {
            Guid imageID = GetGuid();
            Image image = new Image(Path, imageID);
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

        public ResultSet GetAllImages()
        {
            return new ResultSet(Model.Taggables.Select(kvp => kvp.Value).ToList().FindAll(t => t is Image));
        }

        public ResultSet GetAllImageSets()
        {
            return new ResultSet(Model.Taggables.Select(kvp => kvp.Value).ToList().FindAll(t => t is ImageSet));
        }

        public ResultSet RunQuery(string Query)
        {

        }

        public ResultSet GetImagesForSet(Guid SetID)
        {
            if(Model.Taggables.ContainsKey(SetID))
            {
                ImageSet set = Model.Taggables[SetID] as ImageSet;
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
