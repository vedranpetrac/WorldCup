namespace WorldCupWF.CustomUserControl
{
    partial class FavouritePlayerUC
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
            this.playerListPanel = new System.Windows.Forms.Panel();
            this.PlayerFavListPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerListPanel
            // 
            this.playerListPanel.Location = new System.Drawing.Point(49, 36);
            this.playerListPanel.Name = "playerListPanel";
            this.playerListPanel.Size = new System.Drawing.Size(200, 312);
            this.playerListPanel.TabIndex = 0;
            // 
            // PlayerFavListPanel
            // 
            this.PlayerFavListPanel.Location = new System.Drawing.Point(472, 36);
            this.PlayerFavListPanel.Name = "PlayerFavListPanel";
            this.PlayerFavListPanel.Size = new System.Drawing.Size(200, 312);
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
            // FavouritePlayerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayerFavListPanel);
            this.Controls.Add(this.playerListPanel);
            this.Name = "FavouritePlayerUC";
            this.Size = new System.Drawing.Size(739, 399);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PlayerFavListPanel;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel playerListPanel;
    }
}
