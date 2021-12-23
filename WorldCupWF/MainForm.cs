using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupWF.CustomUserControl;
using WorldCupWF.Model;

namespace WorldCupWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();

            var initForm = new InitForm
            {
                ControlBox = false
            };
            initForm.ShowDialog();

            Player player = new Player { FullName = "Ivan Horvat", Position = "Napadac", Number = "99" };

            FavouritePlayerItemUC favouritePlayerItemUC = new FavouritePlayerItemUC(player);


     
            favouritePlayerUC1.AddPlayersToList(favouritePlayerItemUC);
            
        }
    }
}
