using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using WorldCupLibrary.Dal;
using WorldCupLibrary.Models;


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
            
            ConfigFactory configFactory = new ConfigFactory();
            if (configFactory.CheckDataConfig())
            {
                dataConfig = configFactory.LoadDataConfig();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(dataConfig.Culture.ToString());

            }

            InitializeComponent();
            InitDataConfig();
        }

        private void InitDataConfig()
        {
            cbGenderType.Items.Add(Properties.Resources.Female);
            cbGenderType.Items.Add(Properties.Resources.Male);
           

                if (dataConfig.TeamGender == TeamGender.female) cbGenderType.SelectedIndex = 1;
                else cbGenderType.SelectedIndex = 2;

                if (dataConfig.Culture == Culture.hr) cbLanguage.SelectedIndex = 2;
                else cbLanguage.SelectedIndex = 1;
            
            

            selectedNation = configFactory.LoadFavNation();
        }

        
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (cbGenderType.SelectedIndex == 1) dataConfig.TeamGender = TeamGender.female;
            else dataConfig.TeamGender = TeamGender.male;


            if (cbLanguage.SelectedItem.ToString() == "EN") dataConfig.Culture = Culture.en;
            else dataConfig.Culture = Culture.hr;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(dataConfig.Culture.ToString());

            if (cbResolution.SelectedIndex == 0)
            {
                dataConfig.Resolution = Resolution.small;
            }
            else if (cbResolution.SelectedIndex == 1)
            {
                dataConfig.Resolution = Resolution.medium;
            }
            else if (cbResolution.SelectedIndex == 2)
            {
                dataConfig.Resolution = Resolution.fullscreen;
            }

            configFactory.SaveDataConfig(dataConfig);

            new MainWindow().Show();
            this.Close();
        }


        

        
    }
}
