using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorldCupLibrary.Models.Match;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for PlayerGridItem.xaml
    /// </summary>
    public partial class PlayerGridItem : UserControl
    {
        public StartingEleven PlayerSingle { get; set; }
        public PlayerGridItem(StartingEleven playerSingle)
        {
            InitializeComponent();
            PlayerSingle = playerSingle;
            lblPlayerName.Text = PlayerSingle.Name;
            lblPlayerNum.Text = PlayerSingle.ShirtNumber.ToString();
            if (PlayerSingle.PicturePath != null)
            {
                Bitmap playerImage = new Bitmap(PlayerSingle.PicturePath);
                playerImg.Source = playerImg.Source;
            }
            
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PlayerStatWindow playerStatWindow = new PlayerStatWindow(PlayerSingle);
            playerStatWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            playerStatWindow.Topmost = true;
            playerStatWindow.ShowDialog();
        }
    }
}
