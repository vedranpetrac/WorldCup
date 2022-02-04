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
using WorldCupLibrary.Dal;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Nation;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataConfig dataConfig = new DataConfig();
        ConfigFactory configFactory = new ConfigFactory();
        private List<Nation> nations;
        private Nation selectedNation;
        private Nation selectedOponNation;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitWindow initWindow = new InitWindow();
            initWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            initWindow.Topmost = true;
            initWindow.ShowDialog();
            InitDataConfig();




        }

        private void InitDataConfig()
        {

            selectedNation = configFactory.LoadFavNation();
        }

        private Task FillDdl()
        {

            cbNation.Items.Clear();
            foreach (Nation nation in nations)
            {
                cbNation.Items.Add(nation.Country + "(" + nation.FifaCode + ")");
            }
            int pos = nations.FindIndex(nation => nation.FifaCode == selectedNation.FifaCode);
            cbNation.SelectedIndex = pos;
            return Task.CompletedTask;
        }

        private async void initNationAsync()
        {

            nations = await WorldCupDataFactory.GetData.GetNations(dataConfig.TeamGender);

            await FillDdl();


        }

        private void cbNation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbNationOppon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnShowNationDetails_Click(object sender, RoutedEventArgs e)
        {
            NationDetailsWindow nationDetailsWindow = new NationDetailsWindow(selectedNation);
            nationDetailsWindow.ShowDialog();
        }

        private void btnShowOpponNationDetails_Click(object sender, RoutedEventArgs e)
        {
            NationDetailsWindow nationDetailsWindow = new NationDetailsWindow(selectedOponNation);
            nationDetailsWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            initNationAsync();
        }
    }
}
