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
using WorldCupLibrary.Models;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for NationDetailsWindow.xaml
    /// </summary>
    public partial class NationDetailsWindow : Window
    {
        public NationDetailsWindow(Nation nation)
        {
            InitializeComponent();
            lblName.Content = nation.Country;
            lblCode.Content = nation.FifaCode;
            lblPlayed.Content = $"{nation.GamesPlayed} / {nation.Wins} / {nation.Losses} / {nation.Draws}";
            lblGoals.Content = $"{nation.GoalsFor} / {nation.GoalsAgainst} / {nation.GoalDifferential}";
        }
        
    }
}
