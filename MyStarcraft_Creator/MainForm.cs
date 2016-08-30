using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStarcraft_Creator
{
    public partial class MainForm : Form
    {
        NewPlayer newPlayer;

        public MainForm()
        {
            InitializeComponent();

            buttonNewPlayer.Click += (sender, e) =>
            {
                // 새로운 Player Panel 얹기
                if(newPlayer != null)
                {
                    this.Controls.Remove(newPlayer);
                }
                newPlayer = new NewPlayer();
                this.Controls.Add(newPlayer);
            };
        }
    }
}
