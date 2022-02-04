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
using WorldCupLibrary.Dal;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Nation;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for InitWindow.xaml
    /// </summary>
    public partial class InitWindow : Window
    {
        DataConfig dataConfig = new DataConfig();
        ConfigFactory configFactory = new ConfigFactory();
        private List<Nation> nations;
        private Nation selectedNation;

        public InitWindow()
        {
            InitializeComponent();
            InitCbGenderType();
            InitDataConfig();
            

        }

        private void InitDataConfig()
        {
            cbGenderType.Items.Add("female");
            cbGenderType.Items.Add("male");
            if (configFactory.CheckDataConfig())
            {
                dataConfig = configFactory.LoadDataConfig();

                if (dataConfig.TeamGender == TeamGender.female) cbGenderType.SelectedIndex = 0;
                else cbGenderType.SelectedIndex = 1;
            }
            cbGenderType.SelectedIndex = 0;

            selectedNation = configFactory.LoadFavNation();
        }

        private void InitCbGenderType()
        {
            
        }

        private async void initNationAsync()
        {
           
            nations = await WorldCupDataFactory.GetData.GetNations(dataConfig.TeamGender);

            //await FillDdl();
           

        }

        


        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbNation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void cbGenderType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbGenderType.SelectedIndex == 0) dataConfig.TeamGender = TeamGender.female;
            else dataConfig.TeamGender = TeamGender.male;

            initNationAsync();
        }

        private void cbResolution_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void cbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
