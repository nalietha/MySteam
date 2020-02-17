using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamLike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class MySteam : Form
        {
            public MySteam()
            {
                InitializeComponent();
                this._LocString = getSavedLocation();

            }
            private string _LocString = "";
            private bool Editing = false;
            private string SaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MySteam\";
            private string SaveFileName = "DefaultUser.xml";
            private static string CurrentUser = "Default";
            private bool gameAlreadyAdded = false;

            private string NO_FOUND_FILES = "Could not find any files in selected location.";

            private List<Game> GameList = new List<Game>();
            private Game selectedGame = null;

            private string getSavedLocation()
            {
                string sLocation = @"D:\Documents\Projects\MySteam\Testfiles\";
                // Get saved string from setup 
                // setup not implemented yet
                return sLocation;
            }
            public void ChangeSaveLoaction(string newLocation)
            {
                this.SaveLocation = newLocation;
            }

            private void lbGameDisplay_SelectedIndexChanged(object sender, EventArgs e)
            {
                foreach (var item in GameList)
                {
                    if (lbGameDisplay.SelectedItem != null && item.name == lbGameDisplay.SelectedItem.ToString())
                        selectedGame = item;
                }

                if (selectedGame != null)
                {
                    tbTitle.Text = selectedGame.GetGameName();
                    tbDescription.Text = selectedGame.GetGameDescription();
                    lblGamePath.Text = selectedGame.GetGamePath();
                    if (selectedGame.imageLocation != "")
                        pbGameImage.ImageLocation = selectedGame.imageLocation;
                    else
                        pbGameImage.ImageLocation = null;

                }
            }

            private void lbGameDisplay_DoubleClick(object sender, EventArgs e)
            {
                // On Double click launch game
                // Launch game
                Process.Start(selectedGame.path);

            }

            private void btnSearchForGames_Click(object sender, EventArgs e)
            {
                bool bannedfile = false;
                string[] BannedFiles = { "Python.exe", "setup.exe", "dxwebsetup.exe", "pythonw.exe", "zsync.exe", "zsyncmake.exe" };
                string[] files = Directory.GetFiles(_LocString, "*.exe", SearchOption.AllDirectories);

                Dictionary<string, string> filenames = new Dictionary<string, string>();

                // Get the last file name
                foreach (var item in files)
                {
                    bannedfile = false;
                    var s = item;
                    var filenameStart = s.LastIndexOf('\\');
                    s = s.Substring(filenameStart + 1);
                    foreach (var bName in BannedFiles)
                    {
                        if (bName.ToLower() == s.ToLower())
                            bannedfile = true;

                    }
                    if (!bannedfile)
                    {
                        s = s.Substring(0, s.Length - 4);
                        try
                        {
                            filenames.Add(s, item.Substring(0, item.LastIndexOf('\\') + 1));
                        }
                        catch
                        {
                            //
                        }
                    }
                }

                if (files == null)
                {
                    lblErrors.Text = NO_FOUND_FILES;
                    lblErrors.Visible = true;
                }

                // Display names 
                foreach (var item in filenames)
                {
                    if (!lbGameDisplay.Items.Contains(item.Key))
                    {
                        gameAlreadyAdded = false;
                        foreach (var currentGame in GameList)
                        {
                            if (currentGame.filename == item.Key)
                                gameAlreadyAdded = true;
                        }
                        if (!gameAlreadyAdded)
                        {
                            Game game = new Game(item.Key, item.Value);
                            GameList.Add(game);
                            lbGameDisplay.Items.Add(game.name);

                        }
                    }
                }

                List<Game> SortedList = GameList.OrderBy(o => o.name).ToList();
                GameList = SortedList;
                RefreshGameList();
            }

            private void llblChangeSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                LocationPrompt lp = new LocationPrompt();
                var result = lp.ShowDialog();
                if (result == DialogResult.OK)
                    this._LocString = lp.LocString;

            }

            private void MySteam_FormClosing(object sender, FormClosingEventArgs e)
            {
                string filepath = SaveLocation + SaveFileName;
                SaveData newSave = new SaveData(GameList);
                newSave.SaveGameData(SaveLocation, filepath);

            }

            private void btnEditGameName_Click(object sender, EventArgs e)
            {
                if (Editing)
                {
                    btnEditGameName.Text = "Edit";
                    CancelEdit();
                }
                else
                {

                    btnSaveTitleChange.Visible = true;
                    Editing = true;
                    btnEditGameName.Text = "Cancel";
                    tbTitle.ReadOnly = false;
                    tbTitle.Cursor = Cursors.IBeam;
                    tbTitle.Select();
                    tbTitle.Focus();
                }
            }
            private void tbTitle_Leave(object sender, EventArgs e)
            {
                EditTitle();
            }
            private void EditTitle()
            {
                // When the user leaves the title editing box. This saves the name.
                // Checks for dublicate name, 
                if (Editing)
                {
                    if (string.IsNullOrWhiteSpace(tbTitle.Text))
                    {
                        MessageBox.Show("Title cannot be blank.", "ERROR", MessageBoxButtons.OK);
                        CancelEdit();
                    }
                    else
                    {
                        selectedGame.ChangeGameNameTo(tbTitle.Text);
                        RefreshGameList();
                        tbTitle.ReadOnly = true;
                        this.Editing = false;
                        btnEditGameName.Text = "Edit";
                        btnSaveTitleChange.Visible = false;
                        tbTitle.Cursor = Cursors.Default;

                    }
                }
            }

            private void CancelEdit()
            {
                if (Editing)
                {
                    Editing = false;
                    tbTitle.Text = selectedGame.GetGameName();
                    tbTitle.Cursor = Cursors.Default;
                    tbTitle.ReadOnly = true;
                    tbTitle.Select(0, 0);
                    btnEditGameName.Text = "Edit";
                    btnSaveTitleChange.Visible = false;
                }
            }
            private void RefreshGameList()
            {
                lbGameDisplay.Items.Clear();
                foreach (var item in GameList)
                {
                    lbGameDisplay.Items.Add(item.name);
                }
            }
            private void tbTitle_KeyUp(object sender, KeyEventArgs e)
            {
                // on Editing, If enter Change the title
                if (e.KeyCode == Keys.Enter)
                    EditTitle();
                if (e.KeyCode == Keys.Escape)
                    CancelEdit();
            }
            private void MySteam_Load(object sender, EventArgs e)
            {
                string fname = (SaveLocation + SaveFileName);
                if (File.Exists(fname))
                {
                    //Read the save file

                    Type[] extratypes = new Type[0];
                    System.Xml.Serialization.XmlSerializer reader =
                        new System.Xml.Serialization.XmlSerializer(typeof(SaveData), extratypes);
                    System.IO.StreamReader file = new System.IO.StreamReader(@fname);

                    SaveData gamestate = (SaveData)reader.Deserialize(file);
                    GameList = gamestate.GetGameList();
                    file.Close();

                    RefreshGameList();
                }
            }
            private void btnSaveTitleChange_Click(object sender, EventArgs e)
            {
                EditTitle();
            }

            private void lbGameDisplay_Click(object sender, EventArgs e)
            {


            }

            private void deleteGameToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (lbGameDisplay.SelectedItem != null)
                {
                    GameList.RemoveAt(lbGameDisplay.SelectedIndex);
                    lbGameDisplay.Items.RemoveAt(lbGameDisplay.SelectedIndex);
                }
            }

            private void btnDiscSave_Click(object sender, EventArgs e)
            {
                selectedGame.ChangeDescriptionTo(tbDescription.Text);
                btnDiscSave.Visible = false;
            }

            private void btnTagsSave_Click(object sender, EventArgs e)
            {

            }
            private bool editingDescription = false;
            private void btnDiscEdit_Click(object sender, EventArgs e)
            {
                if (editingDescription)
                {
                    CancelDescriptionEdit();
                }
                else
                {
                    btnDescEdit.Text = "Cancel";
                    btnDiscSave.Visible = true;
                    tbDescription.ReadOnly = false;
                    tbDescription.Focus();
                    tbDescription.SelectAll();
                    editingDescription = true;
                }
            }

            private void CancelDescriptionEdit()
            {
                btnDescEdit.Text = "Edit Description";
                editingDescription = false;
                tbDescription.ReadOnly = true;
                tbDescription.Text = selectedGame.description;
            }

            private void btnTagEdit_Click(object sender, EventArgs e)
            {

            }

            private void btnImageChange_Click(object sender, EventArgs e)
            {
                string imageLocation = "";
                try
                {
                    OpenFileDialog imageUpload = new OpenFileDialog();
                    imageUpload.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                    if (imageUpload.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = imageUpload.FileName;
                        selectedGame.ChangeImageLocation(imageLocation);
                        pbGameImage.ImageLocation = imageLocation;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void pbGameImage_Click(object sender, EventArgs e)
            {
                // Open Larger image form
                LargeImage newImage = new LargeImage(selectedGame.imageLocation);
                newImage.ShowDialog();
            }
        }
    }
}
