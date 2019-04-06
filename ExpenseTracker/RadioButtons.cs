using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicInterfaceTutorial
{
    public partial class RadioButtons : UserControl
    {

        bool good;

        public bool Good
        {
            get { return good; }
            set { good = value; }
        }
        bool great;

        public bool Great
        {
            get { return great; }
            set { great = value; }
        }
        public RadioButtons()
        {
            InitializeComponent();
        }

        private void radioButtonGood_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPayee.Checked)
            {
                rbtPayer.Checked = false;
            }
            this.Good = true;
        }

        private void radioButtonGreat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPayer.Checked)
            {
                rbtPayee.Checked = false;
            }
            this.Great = true;
        }

    }
}
