namespace WorldCupWF.CustomUserControl
{
    partial class FavouritePlayersUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerFavListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listSwitch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.switchPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerListPanel
            // 
            this.playerListPanel.AllowDrop = true;
            this.playerListPanel.AutoScroll = true;
            this.playerListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerListPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.playerListPanel.Location = new System.Drawing.Point(3, 3);
            this.playerListPanel.Name = "playerListPanel";
            this.playerListPanel.Size = new System.Drawing.Size(287, 396);
            this.playerListPanel.TabIndex = 4;
            this.playerListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.playerListPanel_DragDrop);
            this.playerListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.playerListPanel_DragEnter);
            // 
            // PlayerFavListPanel
            // 
            this.PlayerFavListPanel.AllowDrop = true;
            this.PlayerFavListPanel.AutoScroll = true;
            this.PlayerFavListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerFavListPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PlayerFavListPanel.Location = new System.Drawing.Point(449, 3);
            this.PlayerFavListPanel.Name = "PlayerFavListPanel";
            this.PlayerFavListPanel.Size = new System.Drawing.Size(287, 396);
            this.PlayerFavListPanel.TabIndex = 5;
            this.PlayerFavListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlayerFavListPanel_DragDrop);
            this.PlayerFavListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlayerFavListPanel_DragEnter_1);
            // 
            // listSwitch
            // 
            this.listSwitch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchPanelToolStripMenuItem});
            this.listSwitch.Name = "listSwitch";
            this.listSwitch.Size = new System.Drawing.Size(181, 48);
            this.listSwitch.Opening += new System.ComponentModel.CancelEventHandler(this.listSwitch_Opening);
            // 
            // switchPanelToolStripMenuItem
            // 
            this.switchPanelToolStripMenuItem.Name = "switchPanelToolStripMenuItem";
            this.switchPanelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.switchPanelToolStripMenuItem.Text = "Switch panel";
            this.switchPanelToolStripMenuItem.Click += new System.EventHandler(this.switchPanelToolStripMenuItem_Click);
            // 
            // FavouritePlayersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayerFavListPanel);
            this.Controls.Add(this.playerListPanel);
            this.Name = "FavouritePlayersUC";
            this.Size = new System.Drawing.Size(739, 399);
            this.Load += new System.EventHandler(this.FavouritePlayersUC_Load);
            this.listSwitch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel playerListPanel;
        private System.Windows.Forms.FlowLayoutPanel PlayerFavListPanel;
        private System.Windows.Forms.ContextMenuStrip listSwitch;
        private System.Windows.Forms.ToolStripMenuItem switchPanelToolStripMenuItem;
    }
}
