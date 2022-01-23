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
using WorldCupLibrary.Dal;
using WorldCupLibrary.Models;

namespace WorldCupWF
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
            InitGenderTypeDdl();
            InitCultureTypeDdl();
        }

        private void InitCultureTypeDdl()
        {
            ddlCulture.Items.Add("en");
            ddlCulture.Items.Add("hr");
            ddlCulture.SelectedIndex = 0;
        }

        private void InitGenderTypeDdl()
        {
            ddlGenderType.Items.Add("female");
            ddlGenderType.Items.Add("male");
            ddlGenderType.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataConfig dataConfig = new DataConfig();
            if (ddlCulture.SelectedItem.ToString() == "en") dataConfig.Culture = Culture.en;
            else dataConfig.Culture = Culture.hr;

            if (ddlGenderType.SelectedIndex == 0) dataConfig.TeamGender = TeamGender.female;
            else dataConfig.TeamGender = TeamGender.male;

            ConfigFactory configFactory = new ConfigFactory();
            configFactory.SaveDataConfig(dataConfig);

            this.Close();
        }
    }
}
