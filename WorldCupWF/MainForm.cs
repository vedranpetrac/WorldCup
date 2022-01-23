using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupLibrary.Dal;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Nation;
using WorldCupWF.CustomUserControl;
using WorldCupWF.Model;

namespace WorldCupWF
{
    public partial class MainForm : Form
    {
        private WorldCupDataFactory worldCupDataFactory;
        private Nation selectedNation;
        private List<Nation> nations;
        private DataConfig dataConfig;

        public MainForm()
        {

            InitializeComponent();
            
            var initForm = new InitForm
            {
                ControlBox = false
            };
            initForm.ShowDialog();

            initDataConfig();
            initWorldCupRepo(dataConfig.TeamGender);
            initNation();


            /*
            Player player = new Player { FullName = "Ivan Horvat", Position = "Napadac", Number = "99" };

            FavouritePlayerItemUC favouritePlayerItemUC = new FavouritePlayerItemUC(player);

            favouritePlayerUC1.AddPlayersToList(favouritePlayerItemUC);
            */


        }

        private void initDataConfig()
        {
            try
            {
                ConfigFactory configFactory = new ConfigFactory();
                dataConfig = configFactory.LoadDataConfig();
                Console.WriteLine(dataConfig.TeamGender);
            }
            catch (Exception)
            {
                throw;
            }
           
            
        }
        private async void initWorldCupRepo(TeamGender teamGender)
        {

            nations = await WorldCupDataFactory.RepoWorldCupData.GetNations(teamGender);

        }
        private void initNation()
        {
            cbNations.Items.Clear();
            foreach (var nation in nations)
            {
                cbNations.Items.Add(nation.Country + "(" + nation.FifaCode + ")");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
