using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            DataConfig dataConfig = new DataConfig();
            ConfigFactory configFactory = new ConfigFactory();
            if (configFactory.CheckDataConfig())
            {
                dataConfig = configFactory.LoadDataConfig();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(dataConfig.Culture.ToString());

            }

            InitializeComponent();

            

            lblGender.Text = Properties.Resources.Cup_Gender;
            label1.Text = Properties.Resources.Language;
            btnConfirm.Text = Properties.Resources.Confirm_Options;

            InitGenderTypeDdl();
            InitCultureTypeDdl();

            if (dataConfig.Culture == Culture.hr) ddlCulture.SelectedIndex = 0;
            if (dataConfig.TeamGender == TeamGender.male) ddlGenderType.SelectedIndex = 1;
        }

        private void InitCultureTypeDdl()
        {
            ddlCulture.Items.Add("en");
            ddlCulture.Items.Add("hr");
            ddlCulture.SelectedIndex = 0;
        }

        private void InitGenderTypeDdl()
        {
            ddlGenderType.Items.Add(Properties.Resources.Female);
            ddlGenderType.Items.Add(Properties.Resources.Male);
            ddlGenderType.SelectedIndex = 1;
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

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(dataConfig.Culture.ToString());

            this.Close();
        }
    }
}
