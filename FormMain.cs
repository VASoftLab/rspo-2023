using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpcLabs.EasyOpc;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.DataAccess.OperationModel;
using OpcLabs.EasyOpc.OperationModel;
using OpcLabs.BaseLib.ComponentModel;

using OpcLabs.BaseLib.Forms.Browsing.Specialized;
using OpcLabs.EasyOpc.DataAccess.AddressSpace;


namespace rspo_2023
{
    public partial class FormMain : Form
    {
        private ApplicationSettings appSet;
        private OpcLabs.EasyOpc.DataAccess.EasyDAClient easyDAClient;
        private bool isSubsribed = false;

        public FormMain()
        {
            InitializeComponent();
            appSet = new ApplicationSettings();
            easyDAClient = new EasyDAClient();
            easyDAClient.ItemChanged += EasyDAClient_ItemChanged;
        }

        private void EasyDAClient_ItemChanged(object sender, EasyDAItemChangedEventArgs e)
        {
            var itemID = e.Arguments.ItemDescriptor.ItemId; // Tag Name
            
            var itemValue = e.Vtq.DisplayValue(); // Tag Value
            var state = (int)e.Arguments.State; // ID

            double itemDouble = Double.Parse(itemValue);

            switch (state)
            {
                case 1:
                    textBoxRamp1.Invoke((MethodInvoker)delegate {
                        textBoxRamp1.Text = itemValue;
                    });
                    opcPanel1.Invoke((MethodInvoker)delegate {
                        opcPanel1.Ramp = itemDouble;
                    });
                    break;
                case 2:
                    textBoxRamp2.Invoke((MethodInvoker)delegate {
                        textBoxRamp2.Text = itemValue;
                    });
                    opcPanel2.Invoke((MethodInvoker)delegate {
                        opcPanel2.Ramp = itemDouble;
                    });
                    break;
                case 3:
                    textBoxRamp3.Invoke((MethodInvoker)delegate {
                        textBoxRamp3.Text = itemValue;
                    });
                    opcPanel3.Invoke((MethodInvoker)delegate {
                        opcPanel3.Ramp = itemDouble;
                    });
                    break;
                case 4:
                    textBoxRamp4.Invoke((MethodInvoker)delegate {
                        textBoxRamp4.Text = itemValue;
                    });
                    opcPanel4.Invoke((MethodInvoker)delegate {
                        opcPanel4.Ramp = itemDouble;
                    });
                    break;
                default:
                    break;
            }
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

            opcPanel1.PanelTitle = "DEVICE 1";
            opcPanel2.PanelTitle = "DEVICE 2";
            opcPanel3.PanelTitle = "DEVICE 3";
            opcPanel4.PanelTitle = "DEVICE 4";
        }

        private void buttonReadItemRamp1_Click(object sender, EventArgs e)
        {
            string tagName = "Simulation Examples.Functions.Ramp1";
            Cursor.Current = Cursors.WaitCursor;
            DAVtq vtq;

            try
            {
                vtq = easyDAClient.ReadItem(
                    appSet.MachineName,
                    appSet.ServerClass,
                    tagName);

                textBoxRamp1.Text = vtq.Value.ToString();
            }
            catch (OpcException ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(
                    ex.InnerException.ToString(),
                    ex.Message,
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            Cursor.Current = Cursors.Default;
        }

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            string tagName1 = "Simulation Examples.Functions.Ramp1";
            string tagName2 = "Simulation Examples.Functions.Ramp2";
            string tagName3 = "Simulation Examples.Functions.Ramp3";
            string tagName4 = "Simulation Examples.Functions.Ramp4";

            isSubsribed = !isSubsribed;
            if (isSubsribed)
            {
                buttonSubscribe.Text = "UNSUBSCRIBE";

                var argumentArray = new DAItemGroupArguments[4];

                argumentArray[0] = new DAItemGroupArguments(
                    appSet.MachineName,
                    appSet.ServerClass,
                    tagName1, appSet.UpdateRate, 1);

                argumentArray[1] = new DAItemGroupArguments(
                    appSet.MachineName,
                    appSet.ServerClass,
                    tagName2, appSet.UpdateRate, 2);

                argumentArray[2] = new DAItemGroupArguments(
                    appSet.MachineName,
                    appSet.ServerClass,
                    tagName3, appSet.UpdateRate, 3);

                argumentArray[3] = new DAItemGroupArguments(
                    appSet.MachineName,
                    appSet.ServerClass,
                    tagName4, appSet.UpdateRate, 4);

                easyDAClient.SubscribeMultipleItems(argumentArray);
            }
            else
            {
                buttonSubscribe.Text = "SUBSCRIBE";
                easyDAClient.UnsubscribeAllItems();
            }
        }
    }
}
