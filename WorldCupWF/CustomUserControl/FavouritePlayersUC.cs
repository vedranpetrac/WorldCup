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

namespace WorldCupWF.CustomUserControl
{
    public partial class FavouritePlayersUC : UserControl

    {
        

        public FavouritePlayersUC()
        {
            InitializeComponent();

            playerListPanel.AllowDrop = true;
            

        }

        public void AddPlayersToList(List<StartingEleven> players)
        {
            foreach (var player in players)
            {
                playerListPanel.Controls.Add(new FavouritePlayerItemUC(player));
                
            }

            
            
        }

        public void AddPlayersToFavList(List<StartingEleven> playersFav)
        {

            foreach (var player in playersFav)
            {
                playerListPanel.Controls.Add(new FavouritePlayerItemUC(player));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
