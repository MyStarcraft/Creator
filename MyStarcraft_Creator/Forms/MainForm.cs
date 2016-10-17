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
        NewUserControl dataPanel;

        public MainForm()
        {
            InitializeComponent();

            dataPanel = new NewPlayer();
            panelMain.Controls.Add(dataPanel);

            buttonNewPlayer.Click += (sender, e) =>
            {
                // 새로운 Player Panel 얹기
                panelMain.Controls.Remove(dataPanel);
                dataPanel = new NewPlayer();
                panelMain.Controls.Add(dataPanel);
            };

            buttonNewMap.Click += (sender, e) =>
            {
                // 새로운 Map Panel 얹기
                panelMain.Controls.Remove(dataPanel);
                dataPanel = new NewMap();
                panelMain.Controls.Add(dataPanel);
            };

            toolTipButtonSave.Click += save;
        }

        private void save(object sender, EventArgs e)
        {
            // 선수 정보 JSON으로 받아서 저장
            dataPanel.save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
