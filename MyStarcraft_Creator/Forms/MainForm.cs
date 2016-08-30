using MyStarcraft_Creator.UserControls;
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
        NewUserControl createUserController;

        public MainForm()
        {
            InitializeComponent();

            createUserController = new NewPlayer();
            panelMain.Controls.Add(createUserController);

            buttonNewPlayer.Click += (sender, e) =>
            {
                // 새로운 Player Panel 얹기
                panelMain.Controls.Remove(createUserController);
                createUserController = new NewPlayer();
                panelMain.Controls.Add(createUserController);
            };

            buttonNewMap.Click += (sender, e) =>
            {
                // 새로운 Map Panel 얹기
                panelMain.Controls.Remove(createUserController);
                createUserController = new NewMap();
                panelMain.Controls.Add(createUserController);
            };
        }
    }
}
