using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupLibrary.Dal;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Match;
using WorldCupLibrary.Models.Nation;
using WorldCupWF.CustomUserControl;
using WorldCupWF.Model;

namespace WorldCupWF
{
    public partial class MainForm : Form
    {

        private Nation selectedNation;
        private List<Nation> nations;
        private DataConfig dataConfig;
        ConfigFactory configFactory;
        private bool inProgress;
        List<Match> nationMatchesList;
        List<StartingEleven> playersList;
        private Bitmap playerImage;

        public MainForm()
        {

            InitializeComponent();



            /*
            Player player = new Player { FullName = "Ivan Horvat", Position = "Napadac", Number = "99" };

            FavouritePlayerItemUC favouritePlayerItemUC = new FavouritePlayerItemUC(player);

            favouritePlayerUC1.AddPlayersToList(favouritePlayerItemUC);
            */


        }

        

        private void InitDataConfig()
        {
            configFactory = new ConfigFactory();
            dataConfig = configFactory.LoadDataConfig();


        }

        private async void initNationAsync()
        {
            inProgress = true;

            lbLoadingNations.Text = "Loading...";
            lbLoadingNations.ForeColor = Color.Red;
            nations = await WorldCupDataFactory.GetData.GetNations(dataConfig.TeamGender);

            await FillDdl();
            lbLoadingNations.Text = "Done";
            lbLoadingNations.ForeColor = Color.Green;
            inProgress = false;

        }

        private async void initNationMatchesAsync(TeamGender teamGender, Nation nation)
        {
            nationMatchesList = await WorldCupDataFactory.GetData.GetMatches(nation, teamGender);
            playersList = nationMatchesList.First().HomeTeamStatistics.StartingEleven;
            playersList.AddRange(nationMatchesList.First().HomeTeamStatistics.Substitutes);
            playersBoxPictures.Items.Clear();
            foreach (var player in playersList)
            {

                
                playersBoxPictures.Items.Add(player.Name);

            }

            
            favouritePlayersUC.AddPlayersToList(playersList);
            initDataGridMatches();

        }

        private void initDataGridMatches()
        {
            dataGridMatches.Rows.Clear();

            foreach (var match in nationMatchesList)
            {
                dataGridMatches.Rows.Add(match.Location, match.Attendance, match.HomeTeam.Country, match.AwayTeam.Country);

            }
        }

        private Task FillDdl()
        {
            while (nations == null)
            {

            }
            cbNations.Items.Clear();
            foreach (var nation in nations)
            {
                cbNations.Items.Add(nation.Country + "(" + nation.FifaCode + ")");
            }
            cbNations.SelectedIndex = 0;
            return Task.CompletedTask;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var initForm = new InitForm
            {
                ControlBox = false
            };

            initForm.ShowDialog();

            InitDataConfig();
            initNationAsync();



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveNation_Click(object sender, EventArgs e)
        {
            if (nations != null)
            {
                selectedNation = nations[cbNations.SelectedIndex];
                configFactory.SaveFavNation(selectedNation);
                lbLoadingNations.Text = "Favourite nation saved.";
                configFactory.SaveFavNation(selectedNation);
                initNationMatchesAsync(dataConfig.TeamGender, selectedNation);


            }
        }

        private void playersBoxPictures_Click(object sender, EventArgs e)
        {
            if (playersBoxPictures.Items.Count != 0)
            {
                StartingEleven player = playersList[playersBoxPictures.SelectedIndex];
                lblPictureBoxName.Text = player.Name;
                playerPictureBox.Image = null;
                if (player.PicturePath != null)
                {
                    playerImage = new Bitmap(player.PicturePath);
                    playerPictureBox.Image = playerImage;
                }
            }
            
        }

        private void printMatchesDataGrid_Click(object sender, EventArgs e)
        {
            printPreviewDialogMatches.ShowDialog();
        }

        private void printDocumentMatches_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);

            this.DrawToBitmap(bmp, new Rectangle
            {
                X = 0,
                Y = 0,

                Width = this.Width,
                Height = this.Height
            });

            e.Graphics.DrawImage(bmp, new Point { X = e.MarginBounds.X, Y = e.MarginBounds.Y });
        }

        private void btnLoadPlayerImg_Click(object sender, EventArgs e)
        {
            if (playersBoxPictures.Items.Count != 0)
            {
                StartingEleven player = playersList[playersBoxPictures.SelectedIndex];
                if (openImageDialog.ShowDialog() == DialogResult.OK)
                {
                    player.PicturePath = openImageDialog.FileName;
                    playerImage = new Bitmap(player.PicturePath);
                    playerPictureBox.Image = playerImage;
                }
            }

           
        }

        private void tabPlayerRang_Click(object sender, EventArgs e)
        {
            if (playersList != null)
            {
                foreach (var player in playersList)
                {
                    if (player.PicturePath != null)
                    {
                        playerImage = new Bitmap(player.PicturePath);
                        dataGridPlayers.Rows.Add(playerImage, player.Name);
                    }
                    else
                    {
                        dataGridPlayers.Rows.Add(player.PicturePath, player.Name);
                    }

                }
            }
        }

        private void tabPlayerRang_Enter(object sender, EventArgs e)
        {
            if (playersList != null)
            {
                foreach (var player in playersList)
                {
                    if (player.PicturePath != null)
                    {
                        playerImage = new Bitmap(player.PicturePath);
                        dataGridPlayers.Rows.Add(playerImage, player.Name);
                    }
                    else
                    {
                        dataGridPlayers.Rows.Add(player.PicturePath, player.Name);
                    }

                }
            }
        }
    }
}

