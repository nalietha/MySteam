using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamLike.Contollers
{
    public class Game
    {
        public Game(string Name, string GameLoc)
        {
            this.name = Name;
            this.path = GameLoc + Name + ".exe";
            this.filename = Name;
        }
        public Game()
        {

        }

        public List<string> Tags = new List<string>();

        public string name = "{NAME}";
        public string filename = "{FILENAME}";
        public string path = null;
        public string description = "{DESCRIPTION}";
        public string imageLocation = "";
        public string GetGameName() => this.name;
        public string GetGamePath() => this.path;
        public string GetGameDescription() => this.description;

        // Info Editing
        // Changing
        public void ChangeGameNameTo(string newName) => this.name = newName;

        public void ChangeDescriptionTo(string newDesc) => this.description = newDesc;
        public void RemoveTags(string TagToRemove)
        {


        }
        public void ChangeImageLocation(string newLoc) => this.imageLocation = newLoc;


    }
}
