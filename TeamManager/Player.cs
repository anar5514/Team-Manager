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
    public partial class Player : UserControl
    {
        public string PlayerNumber { get => number.Text; set => number.Text = value; }
        public string PlayerSurname { get => surname.Text; set => surname.Text = value; }

        public Player()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Properties.Resources.player4;
            //this.BackgroundImageLayout = ImageLayout.Stretch; 
            surname.BackColor = Color.FromArgb(255, 0, 0);
        }
    }
}
