using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamManager
{
    public partial class PlayerLayout : Form
    {
        TeamManager teamManager;
        PlayerInfo[] playerInfo;

        public PlayerLayout(TeamManager teammanager, PlayerInfo[] playerinfo)
        {
            teamManager = teammanager;
            playerInfo = playerinfo;
            InitializeComponent();
        }

        private void PlayerLayout_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.playerlayoutpanel;
            BackgroundImageLayout = ImageLayout.Stretch;

            teamManager.Country = new ComboBox();

            var countryname = (teamManager.Country as string).Split('(', ')');
            labelCountryName.Text = countryname[0];
            flagSelectedCountry.Load($"https://countryflags.io/{countryname[1]}/shiny/64.png");

            players = new Player[11];

            //var arr = teamManager.Layout.ToString().Split('-');
            //var a = arr[0];
            //var b = arr[0];
            //var c = arr[0];

            switch (teamManager.Layout)
            {
                case "4-4-2":
                    for (int i = 0, x1 = 70, x2 = 70, x3 = 170; i < players.Count(); i++)
                    {
                        if (i == 0)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(224, 450);
                        }
                        else if (i <= 4)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x1, 346);
                            x1 += 100;
                        }
                        else if (i <= 8)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x2, 226);
                            x2 += 100;
                        }
                        else
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x3, 62);
                            x3 += 100;
                        }
                    }
                    this.Controls.AddRange(players);
                    break;
                case "4-3-3":
                    for (int i = 0, x1 = 70, x2 = 120, x3 = 120; i < players.Count(); i++)
                    {
                        if (i == 0)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(224, 450);
                        }
                        else if (i <= 4)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x1, 346);
                            x1 += 100;
                        }
                        else if (i <= 7)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x2, 226);
                            x2 += 100;
                        }
                        else
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x3, 62);
                            x3 += 100;
                        }
                    }
                    this.Controls.AddRange(players);
                    break;
                case "5-3-2":
                    for (int i = 0, x1 = 15, x2 = 125, x3 = 170; i < players.Count(); i++)
                    {
                        if (i == 0)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(224, 450);
                        }
                        else if (i <= 5)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x1, 346);
                            x1 += 100;
                        }
                        else if (i <= 8)
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x2, 226);
                            x2 += 100;
                        }
                        else
                        {
                            players[i] = new Player();
                            players[i].PlayerNumber = playerInfo[i].NumberPlayer;
                            players[i].PlayerSurname = playerInfo[i].SurnamePlayer;
                            players[i].Location = new Point(x3, 62);
                            x3 += 100;
                        }
                    }
                    this.Controls.AddRange(players);
                    break;
                default:
                    break;
            }
        }
    }
}
