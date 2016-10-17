using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyStarcraft_Creator.UserControls;
using Newtonsoft.Json;
using MyStarcraft_Creator.Object;
using System.IO;

namespace MyStarcraft_Creator
{
    public partial class NewPlayer : NewUserControl
    {
        Player player;

        public NewPlayer()
        {
            InitializeComponent();

            List<string> type = new List<string>() { "Z", "T", "P" };
            comboBoxType.DataSource = type;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.SelectedIndexChanged += selected;

            player = new Player();
            player.type = (string)comboBoxType.SelectedItem;
        }

        public void selected(object args, EventArgs e)
        {
            player.type = (string)comboBoxType.SelectedItem;
        }

        public override void save()
        {
            player.name = base.getName();
            player.offensive = Int32.Parse(textBoxOffensive.Text);
            player.defensive = Int32.Parse(textBoxDefensive.Text);
            player.aggro = Int32.Parse(textBoxAggro.Text);
            player.control = Int32.Parse(textBoxControl.Text);
            player.resource = Int32.Parse(textBoxResource.Text);
            player.sight = Int32.Parse(textBoxSight.Text);

            string jsonString = JsonConvert.SerializeObject(player);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON|*.json";
            dialog.Title = "Save an json file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(dialog.FileName.ToString());
                file.Write(jsonString);
                file.Close();
            }
        }
    }
}
