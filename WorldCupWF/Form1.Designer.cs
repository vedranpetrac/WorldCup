
namespace WorldCupWF
{
    partial class Form1
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
            this.ddl_codes = new System.Windows.Forms.ComboBox();
            this.spolddl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ddl_codes
            // 
            this.ddl_codes.FormattingEnabled = true;
            this.ddl_codes.Location = new System.Drawing.Point(66, 137);
            this.ddl_codes.Name = "ddl_codes";
            this.ddl_codes.Size = new System.Drawing.Size(312, 21);
            this.ddl_codes.TabIndex = 1;
            // 
            // spolddl
            // 
            this.spolddl.FormattingEnabled = true;
            this.spolddl.Location = new System.Drawing.Point(66, 81);
            this.spolddl.Name = "spolddl";
            this.spolddl.Size = new System.Drawing.Size(312, 21);
            this.spolddl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spolddl);
            this.Controls.Add(this.ddl_codes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddl_codes;
        private System.Windows.Forms.ComboBox spolddl;
    }
}

