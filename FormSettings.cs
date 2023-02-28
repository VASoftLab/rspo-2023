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
    public partial class FormSettings : Form
    {
        private ApplicationSettings appSet;
        
        public FormSettings()
        {
            InitializeComponent();

            appSet = new ApplicationSettings();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            appSet.Load();

            textBoxMachineName.Text = appSet.MachineName;
            textBoxUpdateRate.Text = appSet.UpdateRate.ToString();
            textBoxServerClass.Text = appSet.ServerClass;

            listBoxOPCTags.Items.Clear();
            foreach (var item in appSet.OPCTags)
                listBoxOPCTags.Items.Add(item);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            appSet.MachineName = textBoxMachineName.Text;
            appSet.UpdateRate = Int32.Parse(textBoxUpdateRate.Text);
            appSet.ServerClass = textBoxServerClass.Text;

            appSet.Save();

            DialogResult = DialogResult.OK; 
        }

        private void buttonCacnel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
