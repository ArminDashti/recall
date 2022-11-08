using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recall
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Clear();
                config.AppSettings.Settings.Add("connectionString", connectionStringText.Text);
                config.AppSettings.Settings.Add("tableName", tableNameText.Text);
                config.Save();
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                MessageBox.Show("Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Observer.OnSettingsUpdated?.Invoke();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            connectionStringText.Text = appSettings.Get("connectionString");
            tableNameText.Text = appSettings.Get("tableName");
        }
    }
}
