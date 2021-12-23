namespace WorldCupWF.CustomUserControl
{
    partial class FavouritePlayerItemUC
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
            this.captainCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.playerPosLbl = new System.Windows.Forms.Label();
            this.PlayerNumLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // captainCheck
            // 
            this.captainCheck.AutoSize = true;
            this.captainCheck.Enabled = false;
            this.captainCheck.Location = new System.Drawing.Point(23, 78);
            this.captainCheck.Name = "captainCheck";
            this.captainCheck.Size = new System.Drawing.Size(66, 17);
            this.captainCheck.TabIndex = 2;
            this.captainCheck.Text = "Kapetan";
            this.captainCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(168, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Location = new System.Drawing.Point(22, 21);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(67, 13);
            this.playerNameLbl.TabIndex = 5;
            this.playerNameLbl.Text = "Player Name";
            this.playerNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerPosLbl
            // 
            this.playerPosLbl.AutoSize = true;
            this.playerPosLbl.Location = new System.Drawing.Point(22, 51);
            this.playerPosLbl.Name = "playerPosLbl";
            this.playerPosLbl.Size = new System.Drawing.Size(44, 13);
            this.playerPosLbl.TabIndex = 6;
            this.playerPosLbl.Text = "Position";
            // 
            // PlayerNumLbl
            // 
            this.PlayerNumLbl.AutoSize = true;
            this.PlayerNumLbl.Location = new System.Drawing.Point(148, 82);
            this.PlayerNumLbl.Name = "PlayerNumLbl";
            this.PlayerNumLbl.Size = new System.Drawing.Size(44, 13);
            this.PlayerNumLbl.TabIndex = 7;
            this.PlayerNumLbl.Text = "Number";
            // 
            // FavouritePlayerItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PlayerNumLbl);
            this.Controls.Add(this.playerPosLbl);
            this.Controls.Add(this.playerNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.captainCheck);
            this.Name = "FavouritePlayerItemUC";
            this.Size = new System.Drawing.Size(231, 116);
            this.Load += new System.EventHandler(this.FavouritePlayerItemUC_Load);
            this.Click += new System.EventHandler(this.FavouritePlayerItemUC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox captainCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.Label playerPosLbl;
        private System.Windows.Forms.Label PlayerNumLbl;
    }
}
