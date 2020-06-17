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
    public partial class LargeImage : Form
    {
        public LargeImage()
        {
            InitializeComponent();
        }
        public LargeImage(string imageLocation)
        {
            this._imageLocation = imageLocation;
        }
        private string _imageLocation;



        private void button1_Click(object sender, EventArgs e)
        {
            pbLargeImage.ImageLocation = _imageLocation;
        }


    }
}
