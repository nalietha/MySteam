using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamLike.Forms
{
    public partial class LocationPrompt : Form
    {
        public LocationPrompt()
        {
            InitializeComponent();
        }
        public string LocString = "";
        public string newLocation { get; set; }
        private void btnSearchForDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            DialogResult result = FBD.ShowDialog();

            tbLocationBox.Text = FBD.SelectedPath;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.newLocation = tbLocationBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LocationPrompt_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.LocString = tbLocationBox.Text;
        }
    }
}
