﻿namespace WorldCupWF.CustomUserControl
{
    partial class FavouriteTeamUC
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_favTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_favTeam
            // 
            this.btn_favTeam.Location = new System.Drawing.Point(124, 136);
            this.btn_favTeam.Name = "btn_favTeam";
            this.btn_favTeam.Size = new System.Drawing.Size(311, 38);
            this.btn_favTeam.TabIndex = 1;
            this.btn_favTeam.Text = "Potvrdi odabir";
            this.btn_favTeam.UseVisualStyleBackColor = true;
            // 
            // FavouriteTeamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_favTeam);
            this.Controls.Add(this.comboBox1);
            this.Name = "FavouriteTeamUC";
            this.Size = new System.Drawing.Size(563, 244);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_favTeam;
    }
}
