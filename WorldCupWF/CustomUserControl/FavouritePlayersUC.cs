using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupLibrary.Models.Match;
using WorldCupWF.Model;

namespace WorldCupWF.CustomUserControl
{
    public partial class FavouritePlayersUC : UserControl
    {
        private Control pnlDndStart;

        private FavouritePlayerItemUC selectedPlayerItem;
        private HashSet<FavouritePlayerItemUC> selectedPayers = new HashSet<FavouritePlayerItemUC>();

        public FavouritePlayersUC()
        {
            InitializeComponent();

            playerListPanel.AllowDrop = true;
            

        }

        public void AddPlayersToList(List<StartingEleven> players)
        {
            playerListPanel.Controls.Clear();
            PlayerFavListPanel.Controls.Clear();
            foreach (var player in players)
            {
                FavouritePlayerItemUC favouritePlayerItemUC = new FavouritePlayerItemUC(player);
                favouritePlayerItemUC.MouseDown += new MouseEventHandler(control_MouseDown);
                favouritePlayerItemUC.ContextMenuStrip = listSwitch;
                if (player.Favourite)
                {
                    PlayerFavListPanel.Controls.Add(favouritePlayerItemUC);
                }
                else
                {
                    playerListPanel.Controls.Add(favouritePlayerItemUC);
                }


            }

            
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void playerListPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

       

        private void PlayerFavListPanel_DragEnter_1(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            FavouritePlayerItemUC currControl = sender as FavouritePlayerItemUC;

            if (currControl.Parent.Name == "playerListPanel")
            {
                playerListPanel.AllowDrop = false;
            }
            else
            {
                PlayerFavListPanel.AllowDrop = false;
            }

            if (selectedPayers.Contains(currControl))
            {
                currControl.BorderStyle = BorderStyle.None;
                selectedPayers.Remove(currControl);
            }
            else
            {
                startDragAndDropProc(currControl);
            }
            PlayerFavListPanel.AllowDrop = true;
            playerListPanel.AllowDrop = true;

        }

        private void startDragAndDropProc(FavouritePlayerItemUC favouritePlayerItemUC)
        {
            pnlDndStart = favouritePlayerItemUC.Parent;


            if (selectedPayers.Count < 3)
            {
                selectedPayers.Add(favouritePlayerItemUC);
                foreach (var playerItem in selectedPayers)
                {
                    playerItem.BorderStyle = BorderStyle.FixedSingle;

                }
                
                this.DoDragDrop(new DragDataModel { FavouritePlayerItemUC = selectedPayers }, DragDropEffects.Move);
            }
            else
            {
                MessageBox.Show("Max 3");
                
            }

           
        }



        private void playerListPanel_DragDrop(object sender, DragEventArgs e)
        {
            DragDataModel dragData = e.Data.GetData(typeof(DragDataModel)) as DragDataModel;

            foreach (var favouritePlayerItem in dragData.FavouritePlayerItemUC)
            {
                favouritePlayerItem.BorderStyle = BorderStyle.None;
                if (favouritePlayerItem != null)
                {
                    if (pnlDndStart.Name != ((sender as Control).Name))
                    {
                        playerListPanel.Controls.Add(favouritePlayerItem);
                        favouritePlayerItem.setFav(false);
                    }
                }
            }
            selectedPayers.Clear();
            
        }
       


        private void PlayerFavListPanel_DragDrop(object sender, DragEventArgs e)
        {
            DragDataModel dragData = e.Data.GetData(typeof(DragDataModel)) as DragDataModel;

            foreach (var favouritePlayerItem in dragData.FavouritePlayerItemUC)
            {
                favouritePlayerItem.BorderStyle = BorderStyle.None;
                if (favouritePlayerItem != null)
                {
                    if (pnlDndStart.Name != ((sender as Control).Name))
                    {
                        if (PlayerFavListPanel.Controls.Count < 3)
                        {

                            PlayerFavListPanel.Controls.Add(favouritePlayerItem);
                            favouritePlayerItem.setFav(true);

                        }
                        else
                        {
                            MessageBox.Show("Max 3");
                            break;
                        }
                    }
                }
            }
            selectedPayers.Clear();
        }

        private void FavouritePlayersUC_Load(object sender, EventArgs e)
        {

        }

        private void listSwitch_Opening(object sender, CancelEventArgs e)
        {
            FavouritePlayerItemUC favouritePlayerItemUC = (sender as ContextMenuStrip).SourceControl as FavouritePlayerItemUC;
            selectedPlayerItem = favouritePlayerItemUC;
        }

        private void switchPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (playerListPanel.Controls.Contains(selectedPlayerItem))
            {

                if (PlayerFavListPanel.Controls.Count < 3)
                {
                    playerListPanel.Controls.Remove(selectedPlayerItem);
                    PlayerFavListPanel.Controls.Add(selectedPlayerItem);
                    selectedPlayerItem.setFav(true);
                    selectedPlayerItem = null;
                }
                else
                {
                    MessageBox.Show("Max 3");
                    return;
                }
            }
            else
            {

                selectedPlayerItem.setFav(false);
                PlayerFavListPanel.Controls.Remove(selectedPlayerItem);
                playerListPanel.Controls.Add(selectedPlayerItem);
                selectedPlayerItem = null;
            }
        }
    }
}
