using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStarcraft_Creator
{
    public partial class NewPlayer : UserControl
    {
        public NewPlayer()
        {
            InitializeComponent();

            imageProfile.Click += changeProfileImage;
        }

        private void changeProfileImage(Object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
