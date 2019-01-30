using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace TeamManager
{
    public partial class TeamManager : Form
    {
        private CultureInfo[] cultureInfos = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo regionInfo;
        public PlayerInfo[] ListPlayer { get => listPlayer; set => listPlayer = value; }
        public object Country { get => comboBoxCountry.SelectedItem; set => comboBoxCountry.SelectedItem = value; }
        public object Layout { get => comboBoxLayout.SelectedItem; set => comboBoxLayout.SelectedItem = value; }

        public TeamManager()
        {
            InitializeComponent();
        }

        private void TeamManager_Load(object sender, EventArgs e)
        {

            comboBoxLayout.Items.AddRange(new object[] { "4-4-2", "4-3-3", "5-3-2" });
            ListPlayer = new PlayerInfo[11];

            for (int i = 0, a = 100; i < listPlayer.Count(); i++, a += 50)
            {
                listPlayer[i] = new PlayerInfo(this);
                listPlayer[i].Location = new Point(7, a);
            }
            this.Controls.AddRange(listPlayer);

            foreach (var culture in cultureInfos)
            {
                regionInfo = new RegionInfo(culture.LCID);
                if (!comboBoxCountry.Items.Contains(regionInfo.EnglishName + "(" + regionInfo.TwoLetterISORegionName + ")"))
                    comboBoxCountry.Items.Add(regionInfo.EnglishName + "(" + regionInfo.TwoLetterISORegionName + ")");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {           
            if(comboBoxCountry.SelectedItem == null && comboBoxLayout.SelectedItem == null)
                MessageBox.Show("Please, fill the area that is important ", "Error");
            else if (comboBoxCountry.SelectedItem == null)
                MessageBox.Show("Please, fill the area that include countries", "Error");
            else if(comboBoxLayout.SelectedItem == null)
                MessageBox.Show("Please, fill the area that include layouts", "Error");
            else
            {
                PlayerLayout playerLayout = new PlayerLayout(this, ListPlayer);
                playerLayout.ShowDialog();
            }

        }

        private void comboBoxLayout_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxLayout.SelectedIndex == 0)
            {
                for (int i = 0; i < ListPlayer.Count(); i++)
                {
                    if (i == 0)
                        ListPlayer[i].PositionPlayer = "GK";
                    else if (i <= 4)
                        ListPlayer[i].PositionPlayer = "D";
                    else if (i <= 8)
                        ListPlayer[i].PositionPlayer = "MF";
                    else
                        ListPlayer[i].PositionPlayer = "F";
                }
            }

            else if (comboBoxLayout.SelectedIndex == 1)
            {
                for (int i = 0; i < ListPlayer.Count(); i++)
                {
                    if (i == 0)
                        ListPlayer[i].PositionPlayer = "GK";
                    else if (i <= 4)
                        ListPlayer[i].PositionPlayer = "D";
                    else if (i <= 7)
                        ListPlayer[i].PositionPlayer = "MF";
                    else
                        ListPlayer[i].PositionPlayer = "F";
                }
            }

            else if (comboBoxLayout.SelectedIndex == 2)
            {
                for (int i = 0; i < ListPlayer.Count(); i++)
                {
                    if (i == 0)
                        ListPlayer[i].PositionPlayer = "GK";
                    else if (i <= 5)
                        ListPlayer[i].PositionPlayer = "D";
                    else if (i <= 8)
                        ListPlayer[i].PositionPlayer = "MF";
                    else
                        ListPlayer[i].PositionPlayer = "F";
                }
            }

        }
    }
}
