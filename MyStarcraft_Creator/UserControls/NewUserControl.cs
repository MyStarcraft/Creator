using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStarcraft_Creator.UserControls
{
    public partial class NewUserControl : UserControl
    {
        public NewUserControl()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;

            imageProfile.Click += changeProfileImage;
            imageProfile.Image = imageProfile.InitialImage;
            imageProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void changeProfileImage(Object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All image files|*.jpg; *.jpeg; *.png; *.gif";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = dialog.FileName;
                imageProfile.ImageLocation = filePath;
            }
        }
    }
}
