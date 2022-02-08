using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using WorldCupLibrary.Models.Match;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for PlayerStatWindow.xaml
    /// </summary>
    public partial class PlayerStatWindow : Window
    {
        public PlayerStatWindow(StartingEleven player)
        {
            InitializeComponent();
            lblPlayerName.Content = player.Name;
            lblGoalsCont.Content = player.Hit;
            if (player.Captain)
            {
                lblIsCaptainCont.Content = "Yes";
            }
            else
            {
                lblIsCaptainCont.Content = "No";
            }

            lblPlayerNumCont.Content = player.ShirtNumber;
            lblYellowCartoonsCont.Content = player.YellowCard;
            lblPosCont.Content = player.Position;
            
        }
    }
}
