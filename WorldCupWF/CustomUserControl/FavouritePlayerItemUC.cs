using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupLibrary.Models.Match;
using WorldCupWF.Model;

namespace WorldCupWF.CustomUserControl
{
    public partial class FavouritePlayerItemUC : UserControl
    {
   

        public FavouritePlayerItemUC(StartingEleven player)
        {

        InitializeComponent();

            playerNameLbl.Text = player.Name;
            PlayerNumLbl.Text = player.ShirtNumber.ToString();
            playerPosLbl.Text = player.Position.ToString();
            if (player.Captain)
            {
                captainCheck.Checked = true;
            }

            favShow.Visible = player.Favourite;
            

        }

      


        private void FavouritePlayerItemUC_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void FavouritePlayerItemUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }
    }
}
