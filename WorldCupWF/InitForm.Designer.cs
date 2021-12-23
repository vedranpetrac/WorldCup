
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
            this.ddl_codes = new System.Windows.Forms.ComboBox();
            this.spolddl = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddl_codes
            // 
            this.ddl_codes.FormattingEnabled = true;
            this.ddl_codes.Location = new System.Drawing.Point(66, 102);
            this.ddl_codes.Name = "ddl_codes";
            this.ddl_codes.Size = new System.Drawing.Size(312, 21);
            this.ddl_codes.TabIndex = 1;
            // 
            // spolddl
            // 
            this.spolddl.FormattingEnabled = true;
            this.spolddl.Location = new System.Drawing.Point(66, 52);
            this.spolddl.Name = "spolddl";
            this.spolddl.Size = new System.Drawing.Size(312, 21);
            this.spolddl.TabIndex = 2;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(66, 157);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(312, 54);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Confirm Options";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.spolddl);
            this.Controls.Add(this.ddl_codes);
            this.Name = "InitForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddl_codes;
        private System.Windows.Forms.ComboBox spolddl;
        private System.Windows.Forms.Button btn_confirm;
    }
}

