using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWF
{
    public partial class ConfirmExitDialog : Form
    {
        public ConfirmExitDialog(string header)
        {
            InitializeComponent();

            lblConfirmText.Text = Properties.Resources.Do_you_want_to_close_app;
        }

        private void ConfirmExitDialog_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                btnYes_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnNo_Click(sender, e);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        public static DialogResult ShowDialog(IWin32Window owner, string header)
        {

            using (var confirmExitDialog = new ConfirmExitDialog(header))
            {
                return confirmExitDialog.ShowDialog(owner);
            }
        }
    }
}
