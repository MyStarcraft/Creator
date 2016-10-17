using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyStarcraft_Creator.Object;
using Newtonsoft.Json;

namespace MyStarcraft_Creator.UserControls
{
    public partial class NewMap : NewUserControl
    {
        Map map;

        public NewMap()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            map = new Map();
        }

        public override void save()
        {
            map.name = base.getName();
            map.distance = Int32.Parse(textBoxDistance.Text);
            map.complexity = Int32.Parse(textBoxComplexity.Text);
            map.resources = Int32.Parse(textBoxResources.Text);

            string jsonString = JsonConvert.SerializeObject(map);

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
