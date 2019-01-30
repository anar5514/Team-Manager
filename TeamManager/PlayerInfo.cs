using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamManager
{
    public partial class PlayerInfo : UserControl
    {
        public string PositionPlayer { get => playerPosition.Text; set => playerPosition.Text = value; }
        public string NumberPlayer { get => playerNumber.Text; set => playerNumber.Text = value; }
        public string SurnamePlayer { get => playerSurname.Text; set => playerSurname.Text = value; }
        TeamManager teamManager;

        public PlayerInfo(TeamManager teamManager)
        {
            this.teamManager = teamManager;
            InitializeComponent();
        }

        private void playerSurname_TextChanged(object sender, EventArgs e)
        {
            var sender1 = (sender as TextBox);
            var control = int.TryParse(sender1.Text, out int number);
            if (control)
            {
                sender1.Text = string.Empty;
            }

        }

        private void playerNumber_TextChanged(object sender, EventArgs e)
        {
            var sender1 = (sender as TextBox);
            var  control = int.TryParse(sender1.Text, out int number);
            if (!control)
            {
                sender1.Text = string.Empty;
            }
            
        }
    }
}
