using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupWF.Model;

namespace WorldCupWF.CustomUserControl
{
    public partial class FavouritePlayerItemUC : UserControl
    {
        public FavouritePlayerItemUC()
        {
            InitializeComponent();

        }

        public FavouritePlayerItemUC(Player player)
        {

        InitializeComponent();

            playerNameLbl.Text = player.FullName;
            PlayerNumLbl.Text = player.Number;
            playerPosLbl.Text = player.Position;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FavouritePlayerItemUC_Load(object sender, EventArgs e)
        {

        }

        private void FavouritePlayerItemUC_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }
    }
}
