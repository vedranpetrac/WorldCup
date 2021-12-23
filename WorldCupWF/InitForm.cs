using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupLibrary;
using WorldCupLibrary.Models;

namespace WorldCupWF
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
            spolddl.Items.Add("zensko");
            spolddl.Items.Add("musko");
            spolddl.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                FillDdlWithDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void FillDdlWithDataAsync()
        {
            var results = await ResultRepositoryFactory.GetMenResult();
            foreach (var result in results)
            {
                ddl_codes.Items.Add(result.Country);
            }

            // Select the first item
            ddl_codes.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
