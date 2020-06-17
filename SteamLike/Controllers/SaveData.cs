using SteamLike.Contollers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamLike.Contollers
{
    public class SaveData
    {
        public SaveData(List<Game> games )
        {
            this.SavedGames = games;
        }

        // Empty For XMLSerializer 
        public SaveData()
        {

        }

        public Game SelectedGame;
        public List<Game> SavedGames = new List<Game>();

        public List<Game> GetGameList()
        {
            return this.SavedGames;
        }

        public void SaveGameData(string saveLocation, string filepath)
        {
            // Save current game list

                System.IO.Directory.CreateDirectory(saveLocation);


            Type[] moreTypes = new Type[0];
            System.IO.FileStream file = System.IO.File.Create(filepath);

            System.Xml.Serialization.XmlSerializer XMLWriter =
                new System.Xml.Serialization.XmlSerializer(typeof(SaveData), moreTypes);
            XMLWriter.Serialize(file, this);
            file.Close();
        }
    }
} 
