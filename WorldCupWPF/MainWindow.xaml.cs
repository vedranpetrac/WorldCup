using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
using WorldCupLibrary.Dal;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Match;


namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataConfig dataConfig;
        ConfigFactory configFactory;
        private List<Nation> nations;
        private List<Nation> oponNations;
        private Nation selectedNation;
        private Nation selectedOponNation;
        List<Match> nationMatchesList;
        Match selectedMatch;
        List<StartingEleven> nationPlayers;
        List<StartingEleven> oponNationPlayers;

        public MainWindow()
        {
            InitDataConfig();
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        private void InitDataConfig()
        {
            configFactory = new ConfigFactory();
            dataConfig = configFactory.LoadDataConfig();
            selectedNation = dataConfig.FavNation;
            nationPlayers = dataConfig.FavNationPlayers;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(dataConfig.Culture.ToString());
            Application.Current.MainWindow = this;
            if (dataConfig.Resolution == Resolution.small)
            {
                Height = 600;
                Width = 800;
            }
            else if (dataConfig.Resolution == Resolution.medium)
            {
                Height = 1000;
                Width = 1200;
            }
            else if (dataConfig.Resolution == Resolution.fullscreen)
            {
                WindowState = WindowState.Maximized;
            }
            

        }

        private Task FillDdl()
        {

            cbNation.Items.Clear();
            foreach (Nation nation in nations)
            {
                cbNation.Items.Add(nation.Country + "(" + nation.FifaCode + ")");
            }
            if(selectedNation != null)
            {
                int pos = nations.FindIndex(nation => nation.FifaCode == selectedNation.FifaCode);
                cbNation.SelectedIndex = pos;
            }
            cbNation.SelectedIndex = 0;
            return Task.CompletedTask;
        }

        private async void initNationAsync()
        {

            nations = await WorldCupDataFactory.GetData.GetNations(dataConfig.TeamGender);

            await FillDdl();


        }

        private async void cbNation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbNationOppon.Items.Clear();
            selectedNation = nations[cbNation.SelectedIndex];
            await initNationMatchesAsync(dataConfig.TeamGender, selectedNation);



        }

        

        private void cbNationOppon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbNationOppon.Items.Count > 0)
            {
                string oponNationCode;
                if (nationMatchesList[cbNationOppon.SelectedIndex].HomeTeamCountry != selectedNation.Country)
                {
                    oponNationCode = nationMatchesList[cbNationOppon.SelectedIndex].HomeTeam.Code;
                    selectedMatch = nationMatchesList[cbNationOppon.SelectedIndex];
                }
                else
                {
                    oponNationCode = nationMatchesList[cbNationOppon.SelectedIndex].AwayTeam.Code;
                    selectedMatch = nationMatchesList[cbNationOppon.SelectedIndex];
                }
                selectedOponNation = nations.First(n => n.FifaCode == oponNationCode);

                if (selectedMatch.HomeTeamCountry != selectedNation.Country)
                {
                    lblNationRes.Content = selectedMatch.AwayTeam.Goals;
                    lblOppnNationRes.Content = selectedMatch.HomeTeam.Goals;
                }
                else
                {
                    lblNationRes.Content = selectedMatch.HomeTeam.Goals;
                    lblOppnNationRes.Content = selectedMatch.AwayTeam.Goals;
                }
                fillFootballGrid();
            }
        }

        private void btnShowNationDetails_Click(object sender, RoutedEventArgs e)
        {
            NationDetailsWindow nationDetailsWindow = new NationDetailsWindow(selectedNation);
            nationDetailsWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            nationDetailsWindow.Topmost = true;
            nationDetailsWindow.ShowDialog();
        }

        private void btnShowOpponNationDetails_Click(object sender, RoutedEventArgs e)
        {
            if (selectedOponNation != null)
            {
                NationDetailsWindow nationDetailsWindow = new NationDetailsWindow(selectedOponNation);
                nationDetailsWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                nationDetailsWindow.Topmost = true;
                nationDetailsWindow.ShowDialog();

                initplayerEvevents(nationPlayers, selectedMatch);
                initplayerEvevents(oponNationPlayers, selectedMatch);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            initNationAsync();
        }

        private async Task initNationMatchesAsync(TeamGender teamGender, Nation nation)
        {
            nationMatchesList = await WorldCupDataFactory.GetData.GetMatches(nation, teamGender);

            

            foreach (Match item in nationMatchesList)
            {
                if (item.HomeTeamCountry != selectedNation.Country) { 
                    cbNationOppon.Items.Add(item.HomeTeam.Country);
                    lblNationRes.Content = item.AwayTeam.Goals;
                    lblOppnNationRes.Content = item.HomeTeam.Goals;
                }
                else { 
                    cbNationOppon.Items.Add(item.AwayTeam.Country);
                    lblNationRes.Content = item.HomeTeam.Goals;
                    lblOppnNationRes.Content = item.AwayTeam.Goals;
                }



            }

            cbNationOppon.SelectedIndex = 0;
            
        }

        private void fillFootballGrid()
        {
            footballFieldGrid.Children.Clear();
            if (selectedMatch.HomeTeam.Code == selectedNation.FifaCode)
            {
                nationPlayers = selectedMatch.HomeTeamStatistics.StartingEleven;
                oponNationPlayers = selectedMatch.AwayTeamStatistics.StartingEleven;
            }
            else
            {
                nationPlayers = selectedMatch.AwayTeamStatistics.StartingEleven;
                oponNationPlayers = selectedMatch.HomeTeamStatistics.StartingEleven;
            }
            int d_row = 0, m_row = 0, f_row = 0;
            foreach (StartingEleven player in nationPlayers)
            {
                
                if (player.Position.Equals("Defender"))
                {
                    FillGridPlayerItem(player, 1, d_row++, true);
                }

                else if (player.Position.Equals("Midfield"))
                {

                    FillGridPlayerItem(player, 2, m_row++, true);
                }

                else if (player.Position.Equals("Forward"))
                {
                    FillGridPlayerItem(player, 3, f_row++, true);
                }

            }
            d_row = 0; m_row = 0; f_row = 0;
            foreach (StartingEleven player in oponNationPlayers)
            {
                if (player.Position.Equals("Forward"))
                {
                    FillGridPlayerItem(player, 4, f_row++, false);
                }
                else if (player.Position.Equals("Midfield"))
                {

                    FillGridPlayerItem(player, 5, m_row++, false);
                }
                else if (player.Position.Equals("Defender"))
                {
                    FillGridPlayerItem(player, 6, d_row++, false);

                }



            }

            FillGridPlayerItem(nationPlayers[0], 0, 2,true);
            FillGridPlayerItem(oponNationPlayers[0], 7, 2, false);
        }


        public void FillGridPlayerItem(StartingEleven player, int gridCol,int gridRow, bool isPrimaryTeam)
        {
            PlayerGridItem playerGridItem = new PlayerGridItem(player);

            Grid.SetColumn(playerGridItem, gridCol);
            Grid.SetRow(playerGridItem, gridRow);

            footballFieldGrid.Children.Add(playerGridItem);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            InitWindow initWindow = new InitWindow();
            initWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            initWindow.Topmost = true;
            initWindow.ShowDialog();
            InitDataConfig();
        }

        private void initplayerEvevents(List<StartingEleven> team, Match match)
        {
            
                foreach (TeamEvent teamEvent in match.HomeTeamEvents)
                {
                    fillPlayerStat(teamEvent, team);
                }

                foreach (TeamEvent teamEvent in match.AwayTeamEvents)
                {
                    fillPlayerStat(teamEvent, team);
                }
            
        }

        private void fillPlayerStat(TeamEvent teamEvent, List<StartingEleven> team)
        {
            foreach (StartingEleven player in team)
            {
                if (player.Name == teamEvent.Player)
                {
                    if (teamEvent.TypeOfEvent == "yellow-card")
                    {
                        player.YellowCard++;

                    }
                    else if (teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty")
                    {
                        player.Hit++; ;
                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            configFactory.SaveFavNation(selectedNation);

            new ConfirmExitDialog().ShowDialog();
            e.Cancel = true;
        }
    }

   
}
