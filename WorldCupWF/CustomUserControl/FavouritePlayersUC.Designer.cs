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
            this.PlayerFavListPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.playerListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PlayerFavListPanel
            // 
            this.PlayerFavListPanel.Location = new System.Drawing.Point(444, 3);
            this.PlayerFavListPanel.Name = "PlayerFavListPanel";
            this.PlayerFavListPanel.Size = new System.Drawing.Size(292, 393);
            this.PlayerFavListPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Move To Fav";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove from fav";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // 
            // FavouritePlayersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playerListPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayerFavListPanel);
            this.Name = "FavouritePlayersUC";
            this.Size = new System.Drawing.Size(739, 399);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PlayerFavListPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel playerListPanel;
    }
}
