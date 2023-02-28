using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rspo_2023
{
    public partial class FormMain : Form
    {
        private ApplicationSettings appSet;

        public FormMain()
        {
            InitializeComponent();
            appSet = new ApplicationSettings();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();

            if (formSettings.ShowDialog() == DialogResult.OK)
                appSet.Load();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (appSet != null)
                appSet.Load();
        }
    }
}
