using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWF.CustomUserControl
{
    public partial class FavouritePlayerUC : UserControl

    {
        

        public FavouritePlayerUC()
        {
            InitializeComponent();

            playerListPanel.AllowDrop = true;
            

        }

        public void AddPlayersToList(FavouritePlayerItemUC playerItemUC )
        {
            
            playerListPanel.Controls.Add(playerItemUC);
            
        }
    }
}
