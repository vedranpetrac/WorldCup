
namespace WorldCupWF
{
    partial class InitForm
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
            this.ddlCulture = new System.Windows.Forms.ComboBox();
            this.ddlGenderType = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlCulture
            // 
            this.ddlCulture.FormattingEnabled = true;
            this.ddlCulture.Location = new System.Drawing.Point(66, 115);
            this.ddlCulture.Name = "ddlCulture";
            this.ddlCulture.Size = new System.Drawing.Size(312, 21);
            this.ddlCulture.TabIndex = 1;
            // 
            // ddlGenderType
            // 
            this.ddlGenderType.FormattingEnabled = true;
            this.ddlGenderType.Location = new System.Drawing.Point(66, 52);
            this.ddlGenderType.Name = "ddlGenderType";
            this.ddlGenderType.Size = new System.Drawing.Size(312, 21);
            this.ddlGenderType.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(66, 169);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(312, 54);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm Options";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(63, 27);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Cup Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Language";
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.ddlGenderType);
            this.Controls.Add(this.ddlCulture);
            this.Name = "InitForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlCulture;
        private System.Windows.Forms.ComboBox ddlGenderType;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label1;
    }
}

