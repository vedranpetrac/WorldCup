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
            lblPlayerName.Text = playerSingle.Name;
            lblPlayerNum.Text = playerSingle.ShirtNumber.ToString();
        }
    }
}
