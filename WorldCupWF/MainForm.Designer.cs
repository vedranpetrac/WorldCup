namespace WorldCupWF
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.printMatchesDataGrid = new System.Windows.Forms.Button();
            this.dataGridMatches = new System.Windows.Forms.DataGridView();
            this.cLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVisitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHomeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAwayTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPlayerRang = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridPlayers = new System.Windows.Forms.DataGridView();
            this.playerDataGridImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.playerDataGridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDataGridGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDataGridYellowCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPictureBoxName = new System.Windows.Forms.Label();
            this.playersBoxPictures = new System.Windows.Forms.ListBox();
            this.lblSelectPlayer = new System.Windows.Forms.Label();
            this.btnLoadPlayerImg = new System.Windows.Forms.Button();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.favouritePlayersUC = new WorldCupWF.CustomUserControl.FavouritePlayersUC();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbLoadingNations = new System.Windows.Forms.Label();
            this.btnSaveNation = new System.Windows.Forms.Button();
            this.lbSelectFavTeam = new System.Windows.Forms.Label();
            this.cbNations = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.printPreviewDialogMatches = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentMatches = new System.Drawing.Printing.PrintDocument();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.startingElevenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startingElevenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printDocumentPlayers = new System.Drawing.Printing.PrintDocument();
            this.printDialogPlayers = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatches)).BeginInit();
            this.tabPlayerRang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingElevenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingElevenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LimeGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Options";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.printMatchesDataGrid);
            this.tabPage5.Controls.Add(this.dataGridMatches);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 386);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Matches Rang List";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // printMatchesDataGrid
            // 
            this.printMatchesDataGrid.Location = new System.Drawing.Point(196, 338);
            this.printMatchesDataGrid.Name = "printMatchesDataGrid";
            this.printMatchesDataGrid.Size = new System.Drawing.Size(443, 37);
            this.printMatchesDataGrid.TabIndex = 4;
            this.printMatchesDataGrid.Text = "Print Details";
            this.printMatchesDataGrid.UseVisualStyleBackColor = true;
            this.printMatchesDataGrid.Click += new System.EventHandler(this.printMatchesDataGrid_Click);
            // 
            // dataGridMatches
            // 
            this.dataGridMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLocation,
            this.cVisitors,
            this.cHomeTeam,
            this.cAwayTeam});
            this.dataGridMatches.Location = new System.Drawing.Point(196, 20);
            this.dataGridMatches.Name = "dataGridMatches";
            this.dataGridMatches.Size = new System.Drawing.Size(443, 312);
            this.dataGridMatches.TabIndex = 2;
            // 
            // cLocation
            // 
            this.cLocation.HeaderText = "Location";
            this.cLocation.Name = "cLocation";
            this.cLocation.ReadOnly = true;
            // 
            // cVisitors
            // 
            this.cVisitors.HeaderText = "Column1";
            this.cVisitors.Name = "cVisitors";
            this.cVisitors.ReadOnly = true;
            // 
            // cHomeTeam
            // 
            this.cHomeTeam.HeaderText = "HomeTeam";
            this.cHomeTeam.Name = "cHomeTeam";
            this.cHomeTeam.ReadOnly = true;
            // 
            // cAwayTeam
            // 
            this.cAwayTeam.HeaderText = "Away Team";
            this.cAwayTeam.Name = "cAwayTeam";
            this.cAwayTeam.ReadOnly = true;
            // 
            // tabPlayerRang
            // 
            this.tabPlayerRang.AccessibleName = "tabPlayerRang";
            this.tabPlayerRang.Controls.Add(this.button4);
            this.tabPlayerRang.Controls.Add(this.dataGridPlayers);
            this.tabPlayerRang.Location = new System.Drawing.Point(4, 34);
            this.tabPlayerRang.Name = "tabPlayerRang";
            this.tabPlayerRang.Size = new System.Drawing.Size(792, 386);
            this.tabPlayerRang.TabIndex = 2;
            this.tabPlayerRang.Text = " Players Rang List";
            this.tabPlayerRang.UseVisualStyleBackColor = true;
            this.tabPlayerRang.Click += new System.EventHandler(this.tabPlayerRang_Click);
            this.tabPlayerRang.Enter += new System.EventHandler(this.tabPlayerRang_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(132, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(545, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Print Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridPlayers
            // 
            this.dataGridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerDataGridImage,
            this.playerDataGridName,
            this.playerDataGridGoals,
            this.playerDataGridYellowCards});
            this.dataGridPlayers.Location = new System.Drawing.Point(132, 19);
            this.dataGridPlayers.Name = "dataGridPlayers";
            this.dataGridPlayers.ReadOnly = true;
            this.dataGridPlayers.RowHeadersWidth = 40;
            this.dataGridPlayers.Size = new System.Drawing.Size(545, 316);
            this.dataGridPlayers.TabIndex = 0;
            // 
            // playerDataGridImage
            // 
            this.playerDataGridImage.HeaderText = "";
            this.playerDataGridImage.Name = "playerDataGridImage";
            this.playerDataGridImage.ReadOnly = true;
            // 
            // playerDataGridName
            // 
            this.playerDataGridName.HeaderText = "Player Name";
            this.playerDataGridName.Name = "playerDataGridName";
            this.playerDataGridName.ReadOnly = true;
            this.playerDataGridName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // playerDataGridGoals
            // 
            this.playerDataGridGoals.HeaderText = "Goals";
            this.playerDataGridGoals.Name = "playerDataGridGoals";
            this.playerDataGridGoals.ReadOnly = true;
            // 
            // playerDataGridYellowCards
            // 
            this.playerDataGridYellowCards.HeaderText = "Yellow Cards";
            this.playerDataGridYellowCards.Name = "playerDataGridYellowCards";
            this.playerDataGridYellowCards.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPictureBoxName);
            this.tabPage2.Controls.Add(this.playersBoxPictures);
            this.tabPage2.Controls.Add(this.lblSelectPlayer);
            this.tabPage2.Controls.Add(this.btnLoadPlayerImg);
            this.tabPage2.Controls.Add(this.playerPictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player Pictures";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPictureBoxName
            // 
            this.lblPictureBoxName.AutoSize = true;
            this.lblPictureBoxName.Location = new System.Drawing.Point(432, 276);
            this.lblPictureBoxName.Name = "lblPictureBoxName";
            this.lblPictureBoxName.Size = new System.Drawing.Size(35, 13);
            this.lblPictureBoxName.TabIndex = 6;
            this.lblPictureBoxName.Text = "label3";
            // 
            // playersBoxPictures
            // 
            this.playersBoxPictures.FormattingEnabled = true;
            this.playersBoxPictures.Location = new System.Drawing.Point(12, 44);
            this.playersBoxPictures.Name = "playersBoxPictures";
            this.playersBoxPictures.Size = new System.Drawing.Size(268, 329);
            this.playersBoxPictures.TabIndex = 5;
            this.playersBoxPictures.Click += new System.EventHandler(this.playersBoxPictures_Click);
            // 
            // lblSelectPlayer
            // 
            this.lblSelectPlayer.AutoSize = true;
            this.lblSelectPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPlayer.Location = new System.Drawing.Point(10, 13);
            this.lblSelectPlayer.Name = "lblSelectPlayer";
            this.lblSelectPlayer.Size = new System.Drawing.Size(101, 20);
            this.lblSelectPlayer.TabIndex = 4;
            this.lblSelectPlayer.Text = "Select Player";
            // 
            // btnLoadPlayerImg
            // 
            this.btnLoadPlayerImg.Location = new System.Drawing.Point(435, 307);
            this.btnLoadPlayerImg.Name = "btnLoadPlayerImg";
            this.btnLoadPlayerImg.Size = new System.Drawing.Size(349, 32);
            this.btnLoadPlayerImg.TabIndex = 1;
            this.btnLoadPlayerImg.Text = "Load Image";
            this.btnLoadPlayerImg.UseVisualStyleBackColor = true;
            this.btnLoadPlayerImg.Click += new System.EventHandler(this.btnLoadPlayerImg_Click);
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.ErrorImage = global::WorldCupWF.Properties.Resources.blank_profile_picture;
            this.playerPictureBox.Image = global::WorldCupWF.Properties.Resources.blank_profile_picture;
            this.playerPictureBox.InitialImage = global::WorldCupWF.Properties.Resources.blank_profile_picture;
            this.playerPictureBox.Location = new System.Drawing.Point(435, 27);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(349, 235);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPictureBox.TabIndex = 0;
            this.playerPictureBox.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.favouritePlayersUC);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Favourite Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // favouritePlayersUC
            // 
            this.favouritePlayersUC.Location = new System.Drawing.Point(29, 19);
            this.favouritePlayersUC.Name = "favouritePlayersUC";
            this.favouritePlayersUC.Size = new System.Drawing.Size(730, 356);
            this.favouritePlayersUC.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbLoadingNations);
            this.tabPage4.Controls.Add(this.btnSaveNation);
            this.tabPage4.Controls.Add(this.lbSelectFavTeam);
            this.tabPage4.Controls.Add(this.cbNations);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Favourite Team";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbLoadingNations
            // 
            this.lbLoadingNations.AutoSize = true;
            this.lbLoadingNations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadingNations.Location = new System.Drawing.Point(230, 64);
            this.lbLoadingNations.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbLoadingNations.Name = "lbLoadingNations";
            this.lbLoadingNations.Size = new System.Drawing.Size(300, 16);
            this.lbLoadingNations.TabIndex = 3;
            this.lbLoadingNations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveNation
            // 
            this.btnSaveNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveNation.Location = new System.Drawing.Point(243, 220);
            this.btnSaveNation.Name = "btnSaveNation";
            this.btnSaveNation.Size = new System.Drawing.Size(276, 31);
            this.btnSaveNation.TabIndex = 2;
            this.btnSaveNation.Text = "Save";
            this.btnSaveNation.UseVisualStyleBackColor = true;
            this.btnSaveNation.Click += new System.EventHandler(this.btnSaveNation_Click);
            // 
            // lbSelectFavTeam
            // 
            this.lbSelectFavTeam.AutoSize = true;
            this.lbSelectFavTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectFavTeam.Location = new System.Drawing.Point(184, 95);
            this.lbSelectFavTeam.MinimumSize = new System.Drawing.Size(400, 0);
            this.lbSelectFavTeam.Name = "lbSelectFavTeam";
            this.lbSelectFavTeam.Size = new System.Drawing.Size(400, 20);
            this.lbSelectFavTeam.TabIndex = 1;
            this.lbSelectFavTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNations
            // 
            this.cbNations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNations.FormattingEnabled = true;
            this.cbNations.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.cbNations.Location = new System.Drawing.Point(243, 164);
            this.cbNations.Name = "cbNations";
            this.cbNations.Size = new System.Drawing.Size(276, 24);
            this.cbNations.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPlayerRang);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 424);
            this.tabControl1.TabIndex = 3;
            // 
            // printPreviewDialogMatches
            // 
            this.printPreviewDialogMatches.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogMatches.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogMatches.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogMatches.Document = this.printDocumentMatches;
            this.printPreviewDialogMatches.Enabled = true;
            this.printPreviewDialogMatches.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogMatches.Icon")));
            this.printPreviewDialogMatches.Name = "printPreviewDialogMatches";
            this.printPreviewDialogMatches.Visible = false;
            // 
            // printDocumentMatches
            // 
            this.printDocumentMatches.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentMatches_PrintPage);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // startingElevenBindingSource
            // 
            this.startingElevenBindingSource.DataSource = typeof(WorldCupLibrary.Models.Match.StartingEleven);
            // 
            // startingElevenBindingSource1
            // 
            this.startingElevenBindingSource1.DataSource = typeof(WorldCupLibrary.Models.Match.StartingEleven);
            // 
            // printDocumentPlayers
            // 
            this.printDocumentPlayers.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentPlayers_PrintPage);
            // 
            // printDialogPlayers
            // 
            this.printDialogPlayers.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatches)).EndInit();
            this.tabPlayerRang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startingElevenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingElevenBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource startingElevenBindingSource;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPlayerRang;
        private System.Windows.Forms.DataGridView dataGridPlayers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox playersBoxPictures;
        private System.Windows.Forms.Label lblSelectPlayer;
        private System.Windows.Forms.Button btnLoadPlayerImg;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbLoadingNations;
        private System.Windows.Forms.Button btnSaveNation;
        private System.Windows.Forms.Label lbSelectFavTeam;
        private System.Windows.Forms.ComboBox cbNations;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridMatches;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button printMatchesDataGrid;
        private System.Windows.Forms.Label lblPictureBoxName;
        private System.Windows.Forms.BindingSource startingElevenBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVisitors;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHomeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAwayTeam;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogMatches;
        private System.Drawing.Printing.PrintDocument printDocumentMatches;
        private CustomUserControl.FavouritePlayersUC favouritePlayersUC;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.DataGridViewImageColumn playerDataGridImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridYellowCards;
        private System.Drawing.Printing.PrintDocument printDocumentPlayers;
        private System.Windows.Forms.PrintDialog printDialogPlayers;
    }
}