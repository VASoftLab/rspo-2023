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
    public partial class OPCPanel : UserControl
    {
        private string _PanelTitle;
        private double _Ramp;
        private double _Sine;
        private double _Random;

        public string PanelTitle
        {
            get { return _PanelTitle; }
            set
            {
                _PanelTitle = value;
                groupBoxDevice.Text = _PanelTitle;
            }
        }

        public double Ramp
        {
            set
            {
                _Ramp = value;
                textBoxRamp.Text = _Ramp.ToString("0.00");
            }
        }

        public double Sine
        {
            set
            {
                _Sine = value;
                textBoxSine.Text = _Sine.ToString("0.00");
            }
        }

        public double Random
        {
            set
            {
                _Random = value;
                textBoxRandom.Text = _Random.ToString("0.00");
            }
        }

        public OPCPanel()
        {
            InitializeComponent();
        }
    }
}
