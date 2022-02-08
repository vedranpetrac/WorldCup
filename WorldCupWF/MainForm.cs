using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupLibrary.Dal;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Match;
using WorldCupWF.CustomUserControl;
using WorldCupWF.Model;
using WorldCupWF.Properties;

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


        }

        

        private void InitDataConfig()
        {
            configFactory = new ConfigFactory();
            dataConfig = configFactory.LoadDataConfig();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(dataConfig.Culture.ToString());

            lbSelectFavTeam.Text = Properties.Resources.Select_Your_Favourite_Team_From_Dropdown;
            btnSaveNation.Text = Properties.Resources.Confirm_Options;
            lblSelectPlayer.Text = Properties.Resources.Select_Player;
            lblPictureBoxName.Text = Properties.Resources.Player_Name;
            printMatchesDataGrid.Text = Properties.Resources.Print_Details;
            tabPage4.Text = Properties.Resources.Favourite_Team;
            tabPage1.Text = Properties.Resources.Favourite_Players;
            tabPage2.Text = Properties.Resources.Player_Pictures;
            tabPage5.Text = Properties.Resources.Matches_Rang_List;
            tabPlayerRang.Text = Properties.Resources.Players_Rang_List;

            dataGridPlayers.Columns[0].HeaderText = Properties.Resources.FullName;
            dataGridPlayers.Columns[1].HeaderText = Properties.Resources.Goals;
            dataGridPlayers.Columns[2].HeaderText = Properties.Resources.Yellow_Cards;

            dataGridMatches.Columns[0].HeaderText = Properties.Resources.Location;
            dataGridMatches.Columns[1].HeaderText = Properties.Resources.Visitors;
            dataGridMatches.Columns[2].HeaderText = Properties.Resources.Home_Team;
            dataGridMatches.Columns[3].HeaderText = Properties.Resources.Away_Team;

            
        }

        private async void initNationAsync()
        {
            inProgress = true;

            lbLoadingNations.Text = Properties.Resources.Loading;
            lbLoadingNations.ForeColor = Color.Red;
            nations = await WorldCupDataFactory.GetData.GetNations(dataConfig.TeamGender);
            await FillDdl();
            lbLoadingNations.Text = Properties.Resources.Done;
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

            
            //dataGridMatches.Columns[0].Name;

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
                lbLoadingNations.Text = Properties.Resources.Saved_Nation; ;
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
                else
                {
                    playerPictureBox.Image = Properties.Resources.blank_profile_picture;
                }
            }
            
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

        private void printMatchesDataGrid_Click(object sender, EventArgs e)
        {
            printPreviewDialogMatches.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void printDocumentPlayers_PrintPage(object sender, PrintPageEventArgs e)
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

        

        private void initplayerEvevents(List<StartingEleven> team, List<Match> matches)
        {
            foreach (Match match in matches)
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

        private void tabPlayerRang_Click(object sender, EventArgs e)
        {
            

            if (playersList != null)
            {
                foreach (var player in playersList)
                {
                    if (player.PicturePath != null)
                    {
                        playerImage = new Bitmap(player.PicturePath);
                    }
                    else
                    {
                        playerImage = Properties.Resources.blank_profile_picture;

                    }
                    dataGridPlayers.Rows.Add(playerImage, player.Name, player.Hit, player.YellowCard);
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
                    }
                    else
                    {
                        playerImage = Properties.Resources.blank_profile_picture;

                    }
                    dataGridPlayers.Rows.Add(playerImage, player.Name, player.Hit, player.YellowCard);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataConfig.FavNation = selectedNation;
            dataConfig.FavNationPlayers = playersList;
            configFactory.SaveDataConfig(dataConfig);


            var dialogRes = ConfirmExitDialog.ShowDialog(this,"confirm exit");
            if (dialogRes == DialogResult.No) e.Cancel = true;

            else if (dialogRes == DialogResult.Yes) e.Cancel = false;
 
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            new InitForm().ShowDialog();
            
        }
    }
}

